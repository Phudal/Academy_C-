using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityStartUp : MonoBehaviour
{
    // 맨 처음 실행시켰을 때 한번 호출이 됨
    private void Awake()
    {
        Debug.Log("Awake");
    }
    // 오브젝트가 활성화 되었을 경우 한번 호출
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    // OnEnable이 실행된 다음에 한번 호출
    private void Start()
    {
        Debug.Log("Start");
    }
    // 호출이 규칙적입니다
    private void FixedUpdate()
    {
        Debug.Log("Fixedupdate");
    }
    // 호출이 불규칙적
    private void Update()
    {
        Debug.Log("Update");
    }
    // FixedUpdate, Update가 호출된 뒤 호출
    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }
    // 오브젝트가 비활성화 되었을때 호출
    private void OnDisable()
    {
        
    }
    // 오브젝트가 삭제되었을때 호출
    private void OnDestroy()
    {
        
    }
}
