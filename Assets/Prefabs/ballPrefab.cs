using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballPrefab : MonoBehaviour
{
    public GameObject _ballPrefab;
    private Vector3 originalScale;

    private void Awake()
    {
        // сохраняем оригинальный scale префаба
        originalScale = _ballPrefab.transform.localScale;
        
        // создаем клон объекта и устанавливаем его scale в оригинальный scale префаба
        GameObject ballClone = Instantiate(_ballPrefab);
        ballClone.transform.localScale = originalScale;
    }
}
