using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraFollow : MonoBehaviour
{
    #region Variables

    private Vector3 _offset;
    [SerializeField] private Transform[] target;
    [SerializeField] private float smoothTime;
    private Vector3 _currentVelocity = Vector3.zero;


    #endregion

    #region Unity callbacks

    private void Awake()
    {
        int index = PlayerPrefs.GetInt("selectedCharacter");

        _offset = transform.position - target[index].position;
    }    
        

    private void LateUpdate()
    {
        int index = PlayerPrefs.GetInt("selectedCharacter");

        Vector3 targetPosition = target[index].position + _offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _currentVelocity, smoothTime);
    }



    #endregion
}
