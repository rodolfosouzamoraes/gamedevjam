using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantRotateCtlr : MonoBehaviour
{
    [Header("Velocidade de rotação")]
    [SerializeField] float speed;
    [Header("Eixo a ser rotacionado")]
    [SerializeField] Vector3 axis = new Vector3(1,0,0);
    bool isActived;
    Rigidbody myRigibody;
    // Start is called before the first frame update
    void Start()
    {
        myRigibody = GetComponent<Rigidbody>();
        isActived = true;
    }
    // Update is called once per frame
    void Update()
    {
        if(isActived){
            transform.Rotate (axis*speed*Time.deltaTime*TimeMng.Instance.timeScale); 
        }
        
    }
    /// <summary>
    /// Ativa ou desativa a rotação
    /// </summary>
    public void ChangeActived(){
        isActived = !isActived;
    }
    /// <summary>
    /// Muda a gravidade do objeto quando necessário
    /// </summary>
    public void ChangeGravity(){
        ChangeActived();
        myRigibody.useGravity = !myRigibody.useGravity;
        myRigibody.isKinematic = !myRigibody.isKinematic;
    }
}
