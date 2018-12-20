using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miguel : MonoBehaviour {

        public int LifeNumb;
        public float force;
        public float velocity;
        private Animator animator;
        // Use this for initialization
        void Start()
        {
            animator = GetComponent<Animator>();
            LifeNumb = 7;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.D))
            { // Si el jugador toca la tecla D
                animator.SetInteger("state", 1);
                GetComponent<SpriteRenderer>().flipX = false;
                transform.Translate(velocity * Time.deltaTime, 0.0f, 0.0f);
            }

            if (Input.GetKey(KeyCode.A))
            { // Si el jugador toca la tecla D
                animator.SetInteger("state", 1);
                GetComponent<SpriteRenderer>().flipX = true;
                transform.Translate(-velocity * Time.deltaTime, 0.0f, 0.0f);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetTrigger("Jump");
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, force));
            }

            if (!Input.anyKey)
            {
                animator.SetInteger("state", 0);
            }
        }
    }
