using UnityEngine;
using System.Collections;

// This script moves the character controller forward
// and sideways based on the arrow keys.
// It also jumps when pressing space.
// Make sure to attach a character controller to the same game object.
// It is recommended that you make only one call to Move or SimpleMove per frame.

namespace Movement
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        #region PUBLIC FIELDS
        [Header("Walk / Run Setting")] public float walkSpeed;
        public float runSpeed;
        #endregion


        #region PRIVATE FIELDS

		private GameObject model;               // The model that represents player
		private Actions actions;                // Animation actions controller
        private float m_xAxis;
        private float m_zAxis;
        private Rigidbody m_rb;
        private Vector3 m_groundLocation;
		float horizontal;
		float vertical;
		public string modelName = "SportyGirl";
        private int _rotationSpeed = 60;

        #endregion

		void Awake ()
		{ 
			model = transform.Find (modelName).gameObject;
			actions = model.GetComponent<Actions> ();
			m_groundLocation = transform.position;
			m_rb = GetComponent<Rigidbody> ();
			Physics.gravity = new Vector3(0, -1.0F, 0);
		}


        private void Start()
        {
            #region initializing components
            m_rb = GetComponent<Rigidbody>();
			m_rb.useGravity = true;
			#endregion
        }

		void Update () {
			horizontal = Input.GetAxisRaw("Horizontal");
			vertical = Input.GetAxisRaw("Vertical");
			
			if (Input.GetKey(KeyCode.RightArrow)){
				actions.Stay ();
				transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
				//transform.position += Vector3.right * walkSpeed * Time.deltaTime;
			}
			else if (Input.GetKey(KeyCode.LeftArrow)){
				actions.Stay ();
				transform.Rotate(0, -1*_rotationSpeed * Time.deltaTime, 0);
				//transform.position += Vector3.left * walkSpeed * Time.deltaTime;
			}
			else if (Input.GetKey(KeyCode.UpArrow)){
				actions.Walk ();
				transform.Translate(Vector3.forward * Input.GetAxis("Vertical") *walkSpeed * Time.deltaTime);
				//transform.position += Vector3.forward*walkSpeed* Time.deltaTime;
			}
			else if (Input.GetKey(KeyCode.DownArrow)){
				transform.position += Vector3.down *Time.deltaTime;
			}
			else
			{	
				actions.Stay ();
			}
		}
    }
}