
using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    //API非靜態成員
    //先定義欄為存放並設定代號
    public Transform test1;
    public Transform test2;

    private void Start ()
    {
        //取得 非靜態屬性
        print(test1.position);
        //設定 非靜態屬性
        test1.localScale = new Vector3(10, 10, 10);
        // new Vector3(1,1,1)*5
        test2.localScale = Vector3.one * 5;
    }
    private void Update()
    {
        test1.Rotate(0, 5, 0);
        test2.Translate(0, 0, 1.5f);
    }


}
