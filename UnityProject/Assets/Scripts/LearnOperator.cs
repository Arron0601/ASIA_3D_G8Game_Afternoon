
using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public int A = 10, B = 3;
    public int C = 10, D = 3,E=1,F=10;
    public float G = 1.5f ,H=99.9f;

    public float hp = 50;
    public bool key;
    public int enemy;
    private void Start() 
    {
        #region 數字運算子
        print(A + B);
        print(A - B);
        print(A * B);
        print(A / B);
        print(A % B);
        
        //指派右邊運算完再給左邊
        C = 99 + 1;
        print(C);

        C = C + 1;//原始寫法
        //遞增、遞減++,--
        print(D++);//後置遞增先輸出才運算
        print(++E);//前置遞增先運算再輸出

        //加法指派 - * / %
        F = F + 100;
        F += 100;
        print(F);

        #endregion

        #region 比較運算子
        print(G > H);//F
        print(G < H);//T
        print(G >= H);//F
        print(G <= H);//T
        print(G == H);//F
        print(G != H);//T
        #endregion

        #region 邏輯運算子
        //並且&& 有一個false結果是false
        print(true && true); //t
        print(true && false);//f
        print(false && true);//f
        print(false && false);//f

        //或者 || 有一個true結果就是true
        print(true || true); //t
        print(true || false); //t
        print(false || true); //t
        print(false || false); //f

        //相反(顛倒)
        print(!true);//f
        print(!false);//t
        #endregion

    }
    private void Update()
    {
        print("掛囉:" + (hp <= 0));
        print("過關:" + (key || enemy >= 5));
    
    }
}
