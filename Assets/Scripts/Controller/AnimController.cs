using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    [SerializeField] public GameObject player;
    private Rigidbody2D _rigidbody;
    private Animator _anim;

    private void Awake()
    {
        _rigidbody = player.GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_rigidbody.velocity.magnitude > 0.1f)
        {
            _anim.SetBool("IsWalking", true);
        }
        else
        {
            _anim.SetBool("IsWalking", false);
        }
    }
}
