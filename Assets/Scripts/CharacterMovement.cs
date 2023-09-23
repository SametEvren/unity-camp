using UnityEditor.PackageManager;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 3;
    public float rotationSpeed;

    [SerializeField] private CharacterController controller;

    [SerializeField] private Animator animatorController;

    [SerializeField] private Camera mainCamera;
    private static readonly int IsRunning = Animator.StringToHash("isRunning");
    private static readonly int Jump = Animator.StringToHash("Jump");

    private void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        var direction = movement.normalized;

        if (Input.GetKeyDown(KeyCode.Space))
            animatorController.SetTrigger(Jump);
        
        if (!(direction.magnitude >= 0.1f))
        {
            animatorController.SetBool(IsRunning, false);
            return;
        }
        
        animatorController.SetBool(IsRunning, true);

        var targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + mainCamera.transform.eulerAngles.y;

        var angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref rotationSpeed, 0.1f);
        
        transform.rotation = Quaternion.Euler(0,angle,0);

        var moveDirection = Quaternion.Euler(0, targetAngle, 0) * Vector3.forward;

        controller.Move(moveDirection.normalized * (moveSpeed * Time.deltaTime));
    }
}
