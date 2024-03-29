using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    // ゲームオーバーテキスト
    private GameObject gameOverText;
    // 走行距離テキスト
    private GameObject runLengthText;
    // 走った距離
    private float len = 0;
    // 走る速度
    private float speed = 5f;
    // ゲームオーバーの判定
    private bool isGameOver = false;

    void Start()
    {
        // シーンビューからオブジェクトの実体を検索する
        this.gameOverText = GameObject.Find("GameOver");
        this.runLengthText = GameObject.Find("RunLength");
    }

    void Update()
    {
        if (this.isGameOver)//ゲームオーバー時
        {
            // クリックされたらシーンをロードする
            if (Input.GetMouseButtonDown(0))
            {
                //SampleSceneを読み込む（追加）
                SceneManager.LoadScene("SampleScene");
            }
            return;
        }
        else
        {
            // 走った距離を更新する
            this.len += this.speed * Time.deltaTime;

            // 走った距離を表示する
            this.runLengthText.GetComponent<Text>().text = "Distance:  " + len.ToString("F2") + "m";
        }
    }

    public void GameOver()
    {
        // ゲームオーバーになったときに、画面上にゲームオーバを表示する
        this.gameOverText.GetComponent<Text>().text = "Game Over";
        this.isGameOver = true;
    }
}