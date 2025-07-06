using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Monster : MonoBehaviour, Shooter
    {
        [SerializeField] Bullet bullet;
        float lastBulletTime;

        // Use this for initialization
        void Start()
        {
            lastBulletTime = Time.time;
        }

        // Update is called once per frame
        void Update()
        {
            float lapse = Time.time - lastBulletTime;
            //Debug.Log(lapse);
            //transform.Translate(Random.value,0,0);
            if (lapse > 3)
            {
                Shoot();
                lastBulletTime= Time.time;
            }
        }

        public void Shoot()
        {
            Bullet mbullet = Instantiate(bullet, transform.position, transform.rotation);
            mbullet.Init(new Vector3(-1f, -1f, 0));
        }
    }
}