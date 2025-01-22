using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private static readonly int Speed = Animator.StringToHash("speed");
    
    private Animator _animator;
    
    [SerializeField]
    private float _speed;

    [SerializeField] private float _speedChangeValue = 0.1f;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _speed += _speedChangeValue;
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            _speed -= _speedChangeValue;
        }
        if (Input.GetMouseButtonDown(0))
        {
            int randomAttack = Random.Range(0, 2); // 0 или 1
            if (randomAttack == 0)
            {
                _animator.SetTrigger("Attack1");
            }
            else
            {
                _animator.SetTrigger("Attack2");
            }
           
        }
        _animator.SetFloat(Speed, _speed);
    }
}
