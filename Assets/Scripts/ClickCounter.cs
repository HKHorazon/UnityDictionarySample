using TMPro;
using UnityEngine;

// BA15 UI 按鈕：在 Button 的 On Click 選這個物件的 ClickCounter.OnClick
public class ClickCounter : MonoBehaviour
{
    // 要顯示次數的文字，從 Hierarchy 把 Text 拖進來
    public TMP_Text label;

    int count = 0;

    public void OnClick()
    {
        count = count + 1;
        label.text = "按了 " + count + " 次";
    }
}
