public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start Game");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, transform.position.y + 0.01f, 0);//������� �������
        transform.Translate(0, 0.1f, 0);//��������
        transform.Rotete(0, 90 / 60f, 0);//��������.
    }
}
