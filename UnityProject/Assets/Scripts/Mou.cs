using UnityEngine;  // 引用 Unity API

// 類別 類別名稱
public class Mou : MonoBehaviour
{
    #region 欄位區域
    // 宣告變數 (定義欄位 Field)
    // 修飾詞 欄位類型 欄位名稱 (指定 值) 結束
    // 私人 - 隱藏 private (預設)
    // 公開 - 顯示 public 
    [Header("移動速度")][Range(1, 2000)]
    public int speed = 10;             // 整數 1, 9999, -100
    [Header("旋轉速度"), Tooltip("G8雞的旋轉速度"), Range(1.5f, 200f)]
    public float turn = 20.5f;         // 浮點數
    [Header("是否完成任務")]
    public bool mission;               // 布林值 true false
    [Header("玩家名稱")]
    public string _name = "G8雞";      // 字串 ""

    

    #endregion

    public Transform tran;
    public Rigidbody rig;
    public Animator ani;

    public AudioSource aud;
    public AudioClip SoundBark;
    public Rigidbody rigCatch;

    private void Update()
    {
        Turn();
        Run();
        Catch();
    }
    private void OnTriggerStay(Collider other)
    {
        print( other.name);
        if(other.name =="heart" && ani.GetCurrentAnimatorStateInfo(0).IsName("GetHit"))
        {
            Physics.IgnoreCollision(other,GetComponent<Collider>());
            other.GetComponent<HingeJoint>().connectedBody = rigCatch;
        }
        if (other.name == "rpgpp_lt_bush_02 (1)" && ani.GetCurrentAnimatorStateInfo(0).IsName("GetHit"))
        {
            
            GameObject.Find("heart").GetComponent<HingeJoint>().connectedBody = null;
        }

    }
    #region 方法區域
    /// <summary>
    /// 跑步
    /// </summary>
    private void Run()
    {
        if (ani.GetCurrentAnimatorStateInfo(0).IsName("Gethit")) return; 
          
            float v = Input.GetAxis("Vertical");
        //世界座標
        //rig.AddForce(0,0,speed*v);
            //區域座標
            //tran.right區域座標x軸
            //tran.up   區域座標y軸
            rig.AddForce(tran.forward * speed * v *Time.deltaTime);//區域座標z軸
        ani.SetBool("walk", v != 0);
           
    }

    /// <summary>
    /// 旋轉
    /// </summary>
    private void Turn()
    {
        float h=Input.GetAxis("Horizontal");
        tran.Rotate(0, turn * h *Time.deltaTime, 0);
    }

    /// <summary>
    /// 亂叫
    /// </summary>
    private void Bark()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ani.SetTrigger("");

            aud.PlayOneShot(SoundBark);
        }
            
    }

    /// <summary>
    /// 撿東西
    /// </summary>
    private void Catch()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ani.SetTrigger("gethit");
        }
    }

    /// <summary>
    /// 檢視任務
    /// </summary>
    private void Task()
    {

    }
    #endregion
}