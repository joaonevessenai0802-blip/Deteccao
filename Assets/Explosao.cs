using UnityEngine;

public class Explosao : MonoBehaviour
{
    [SerializeField] GameObject explosao;

    private void ONTriggerEnter(Collider other)
    {
        explosao.SetActive(true);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
