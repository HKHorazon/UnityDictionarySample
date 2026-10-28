using UnityEngine;

// BA12 第一支腳本：掛在物件上，讓它一直旋轉
public class Rotator : MonoBehaviour
{
    // 每秒轉幾度，可以在 Inspector 調整
    public float speed = 90f;

    // 開始執行時跑一次
    void Start()
    {
        Debug.Log(name + " 開始旋轉了！");
    }

    // 每一幀跑一次
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
