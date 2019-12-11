
using UnityEngine;

public class LearnIf : MonoBehaviour
{
    public bool openDoor;
    public int score = 100;
    private void Start()
    {
         //語法if(布林值) {陳述式或演算法}
   //()內的林值為true執行{}
   if (false)
	{
            print("yeyeyeyeyeyeyeye");
	}

    }
    private void Update()
    {
        if (openDoor)
        {
            print("開門~");
        }
        else
        {
            //if()內的布林值為false執行else{}
            print("不開~");
        }
        if (score == 60)
        {
            print("及格");
        }
        else if (score>=50)
        {
            print("可以補考~");
        }
        else if (score>=40)
        {
            print("付錢讓你補考");
        } 
        else
        {
            print("被當拉~");
        }
    }
}
