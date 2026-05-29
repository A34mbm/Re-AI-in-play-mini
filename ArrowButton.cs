using UnityEngine;

public class ArrowButton: MonoBehaviour
{
    public int fromIndex;
    // どこのブロックへ進むか
    public int targetIndex;

    // 加算値
    public int addValue;

    // プレイヤー参照
    public PlayerMove player;

    void OnMouseDown()
    {
        if(player.currentIndex != fromIndex)
        {
            Debug.Log("この矢印は使えません");
            return;
        }
        player.MoveTo(targetIndex, addValue);
    }
}
