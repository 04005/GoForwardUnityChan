using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    // �Q�[���I�[�o�[�e�L�X�g
    private GameObject gameOverText;
    // ���s�����e�L�X�g
    private GameObject runLengthText;
    // ����������
    private float len = 0;
    // ���鑬�x
    private float speed = 5f;
    // �Q�[���I�[�o�[�̔���
    private bool isGameOver = false;

    void Start()
    {
        // �V�[���r���[����I�u�W�F�N�g�̎��̂���������
        this.gameOverText = GameObject.Find("GameOver");
        this.runLengthText = GameObject.Find("RunLength");
    }

    void Update()
    {
        if (this.isGameOver)//�Q�[���I�[�o�[��
        {
            // �N���b�N���ꂽ��V�[�������[�h����
            if (Input.GetMouseButtonDown(0))
            {
                //SampleScene��ǂݍ��ށi�ǉ��j
                SceneManager.LoadScene("SampleScene");
            }
            return;
        }
        else
        {
            // �������������X�V����
            this.len += this.speed * Time.deltaTime;

            // ������������\������
            this.runLengthText.GetComponent<Text>().text = "Distance:  " + len.ToString("F2") + "m";
        }
    }

    public void GameOver()
    {
        // �Q�[���I�[�o�[�ɂȂ����Ƃ��ɁA��ʏ�ɃQ�[���I�[�o��\������
        this.gameOverText.GetComponent<Text>().text = "Game Over";
        this.isGameOver = true;
    }
}