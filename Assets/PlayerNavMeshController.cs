using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavMeshController : MonoBehaviour
{
    //[SerializeField] private Transform movePositionTransform;
    private NavMeshAgent NavMeshAgent;
    [SerializeField] private float Speed;
    protected Transform _transform;
    protected Vector3 targetPos;
    public Camera mainCamera;
    private Transform localTrans;
    private Vector3 lastMousePos;
    private Vector3 mousePos;
    private Vector3 newPosForTrans;
    public float SwipeSpeed;


    private void Start()
    {
        localTrans = GetComponent<Transform>();
        //_transform = this.transform;
        //targetPos = this._transform.position;
    }
    private void Awake()
    {
        //NavMeshAgent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mousePos = mainCamera.ScreenToViewportPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
            float xDiff = mousePos.x - lastMousePos.x;
            newPosForTrans.x = localTrans.position.x + xDiff * SwipeSpeed;
            newPosForTrans.y = localTrans.position.y;
            newPosForTrans.z = localTrans.position.z;
            localTrans.position = newPosForTrans + localTrans.forward * Speed * Time.deltaTime;
            lastMousePos = mousePos;
        }
        //gameObject.GetComponent<Rigidbody>().velocity = Vector3.forward * Speed;
        //NavMeshAgent.destination = movePositionTransform.position;
        
    }
    /*void MoveTo()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(mousePos);
            RaycastHit hitInfo;
            bool isCast = Physics.Raycast(ray, out hitInfo, 1000);
            if (isCast)
            {
                targetPos = hitInfo.point;
            }
        }
        
        Vector3 pos = Vector3.MoveTowards(this._transform.position, targetPos, Speed * Time.deltaTime);
        this._transform.position = pos;
    }
    */
}
