using TMPro;
using UnityEngine;

public class DamageNumber : MonoBehaviour
{
    [SerializeField] private TMP_Text damageText;
    private float Speed;

    void Start()
    {
        Speed = Random.Range(0.1f, 1.5f);
        Destroy(gameObject, 1);
    }

    void Update()
    {
        transform.position += Vector3.up * Time.deltaTime * Speed;
    }

    public void SetValue(int value){
        damageText.text = value.ToString();
    }
}
