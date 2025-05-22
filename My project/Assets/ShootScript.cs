using UnityEngine;

public class ShootScript : MonoBehaviour
{
    [SerializeField] private GameObject Bullet;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { Instantiate(Bullet, transform.position,Quaternion.Euler(transform.forward)); }
    }
}
