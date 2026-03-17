using UnityEngine;

namespace Script
{
    public class NewMonoBehaviourScript : MonoBehaviour
    {
        private Rigidbody2D _rb;

        public float speed;
        public float jump;
        public bool isGrounded = true;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.W) && isGrounded)
            {
                isGrounded = false;
                _rb.AddForce(Vector2.up * jump);
            }
            
            if (Input.GetKey(KeyCode.D))
            {
                _rb.AddForce(Vector2.right * speed);
            }
            if (Input.GetKey(KeyCode.A))
            {
                _rb.AddForce(Vector2.left * speed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                _rb.AddForce(Vector2.down * speed);
            }
            
        }
        
        private void OnCollisionEnter2D(Collision2D collision)
        {
            isGrounded = true;
        }
    }
}
