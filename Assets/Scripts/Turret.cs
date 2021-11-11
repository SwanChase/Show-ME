using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{

	private Transform target;
	private PlayerTarget targetEnemy;

	[Header("General")]

	public float range = 15f;

	[Header("Use Bullets (default)")]
	public GameObject bulletPrefab;
	public float fireRate = 1f;
	private float fireCountdown = 0f;

	[Header("Unity Setup Fields")]

	public string targetTag = "Player";

	public Transform partToRotate;
	public float turnSpeed = 10f;

	public Transform Barrel;

	// Use this for initialization
	void Start()
	{
		InvokeRepeating("UpdateTarget", 0f, 0.5f);
	}

	void UpdateTarget()
	{
		GameObject[] Targets = GameObject.FindGameObjectsWithTag(targetTag);
		float shortestDistance = Mathf.Infinity;
		GameObject nearestTarget = null;
		foreach (GameObject _target in Targets)
		{
			float distanceToEnemy = Vector3.Distance(transform.position, _target.transform.position);
			if (distanceToEnemy < shortestDistance)
			{
				shortestDistance = distanceToEnemy;
				nearestTarget = _target;
			}
		}

		if (nearestTarget != null && shortestDistance <= range)
		{
			target = nearestTarget.transform;
			targetEnemy = nearestTarget.GetComponent<PlayerTarget>();
		}
		else
		{
			target = null;
		}

	}

	// Update is called once per frame
	void Update()
	{
        if (target==null)
        {
			return;
        }

		LockOnTarget();
		{
			if (fireCountdown <= 0f)
			{
				Shoot();
				fireCountdown = 1f / fireRate;
			}

			fireCountdown -= Time.deltaTime;
		}

	}

	void LockOnTarget()
	{
		Vector3 dir = target.position - transform.position;
		Quaternion lookRotation = Quaternion.LookRotation(dir);
		Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
		partToRotate.rotation = Quaternion.Euler(rotation.x, rotation.y, 0f);
	}

	void Shoot()
	{
		GameObject bulletGO = Instantiate(bulletPrefab, Barrel.position, Barrel.rotation);
		Bullet bullet = bulletGO.GetComponent<Bullet>();

		
	}

	void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, range);
	}
}
