using UnityEngine;

public class Rotate : MonoBehaviour
{    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start game");
    }

    float targetDistance = 10f; // ����� ����������, �� ������� ����� ����������� ������
    float moveIncrement = 0.1f; // �������� ����������� �� ����
    float movedDistance = 0f; // ���������� ����������
    bool isMovingUp = true; // ���� ��� ����������� ����������� ��������

    // Update is called once per frame
    void Update()
    {
        if (isMovingUp)
        {
            if (movedDistance < targetDistance)
            {
                float moveAmount = Mathf.Min(moveIncrement, targetDistance - movedDistance);
                transform.Translate(0, moveAmount, 0); // ���������� ������ �� ��� Y �����
                movedDistance += moveAmount; // ����������� ���������� ����������
                transform.Rotate(0, 90 / 60f, 0); // ��������
            }
            else
            {
                isMovingUp = false; // ������ ����������� ��������
            }
        }
        else
        {
            if (movedDistance > 0)
            {
                float moveAmount = Mathf.Min(moveIncrement, movedDistance);
                transform.Translate(0, -moveAmount, 0); // ���������� ������ �� ��� Y ����
                movedDistance -= moveAmount; // ��������� ���������� ����������
                transform.Rotate(0, 90 / 60f, 0); // ��������
            }
        }
    }


}
