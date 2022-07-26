using Character.SO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Character.Component
{
    [RequireComponent(typeof(Rigidbody))]
    public class CharacterController : MonoBehaviour
    {
        [SerializeField] private CharacterControllerSettings characterControllerSettings;
        [SerializeField] private Camera _camera;

        private Rigidbody _rigidbody;
        private Vector3 resultMovementVelocity;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        void Start()
        {

        }

        void Update()
        {
            resultMovementVelocity = Vector3.zero;
            if (Input.GetKey(KeyCode.W))
                resultMovementVelocity += new Vector3(transform.forward.x, 0, transform.forward.z);
            if (Input.GetKey(KeyCode.S))
                resultMovementVelocity -= new Vector3(transform.forward.x, 0, transform.forward.z);
            if (Input.GetKey(KeyCode.A))
                resultMovementVelocity -= new Vector3(transform.right.x, 0, transform.right.z);
            if (Input.GetKey(KeyCode.D))
                resultMovementVelocity += new Vector3(transform.right.x, 0, transform.right.z);
            //resultMovementVelocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            characterControllerSettings.CameraRotationBehaviour.Rotate(_camera.transform, new Vector3(0, 0, Input.GetAxis("Mouse Y")));
            characterControllerSettings.CharacterRotationBehaviour.Rotate(transform, new Vector3(Input.GetAxis("Mouse X"), 0, 0));

        }

        private void FixedUpdate()
        {
            characterControllerSettings.MovementBehaviour.Move(_rigidbody, resultMovementVelocity);
        }
    }
}