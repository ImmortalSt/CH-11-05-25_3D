using UnityEngine;

public class Rotate : MonoBehaviour
{    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start game");
    }

    float targetDistance = 10f; // Общее расстояние, на которое нужно переместить объект
    float moveIncrement = 0.1f; // Интервал перемещения за кадр
    float movedDistance = 0f; // Пройденное расстояние
    bool isMovingUp = true; // Флаг для определения направления движения

    // Update is called once per frame
    void Update()
    {
        if (isMovingUp)
        {
            if (movedDistance < targetDistance)
            {
                float moveAmount = Mathf.Min(moveIncrement, targetDistance - movedDistance);
                transform.Translate(0, moveAmount, 0); // Перемещаем объект по оси Y вверх
                movedDistance += moveAmount; // Увеличиваем пройденное расстояние
                transform.Rotate(0, 90 / 60f, 0); // Вращение
            }
            else
            {
                isMovingUp = false; // Меняем направление движения
            }
        }
        else
        {
            if (movedDistance > 0)
            {
                float moveAmount = Mathf.Min(moveIncrement, movedDistance);
                transform.Translate(0, -moveAmount, 0); // Перемещаем объект по оси Y вниз
                movedDistance -= moveAmount; // Уменьшаем пройденное расстояние
                transform.Rotate(0, 90 / 60f, 0); // Вращение
            }
        }
    }


}
