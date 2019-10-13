using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // 플레이어가 이동할 때 적용될 속도
    public float m_MoveSpeed = 10.0f;
    // 변수(필드)를 public 으로 선언할 경우, 인스펙터창에 노출

    // 방향 벡터를 저장할 변수
    private Vector2 _DirectionVector = Vector2.zero;

    // 유니티에서 오브젝트 위치를 변경하는 3가지 방법
    // 1) 오브젝트의 좌표를 특정 좌표로 변경
    // position = Vector
    // 2) 특정한 방향으로 이동
    // position += Vector / Translate()
    // 3) 물리엔진 이용해서 특정한 방향으로 힘을 주어 이동
    // Regidbody2D.velocity / AddForce()


    // Start, Update등의 함수는 위에 있어야함



    // 특정 좌표로 움직임
    private void Start()
    {
        // SetPosition();


    }
    private void Update()
    {

        MovePosition();
    }
    private void SetPosition()
    {
        gameObject.transform.position = new Vector2(10.0f, 10.0f);
    }
        // 특정한 방향으로 이동
    private void MovePosition()
    {
        // 월드 기준(_MoveSpeed, 0.0f) 만큼 이동
        //transform.position = new Vector2(m_MoveSpeed, 0.0f);
        transform.Translate(new Vector2(m_MoveSpeed, 0.0f) * Time.deltaTime, Space.World);  // Space.World가 relateiveTo
        // transfrom.Translate(translate, relativeTo);
        // relative기준으로 translate 이동을 시킵니다.
        // translation : 이동시킬 거리
        // relativeTo : Space.self : 기준을 자기 자신으로 설정
        //              Space.World : 기준을 월드로 설정

        // Time.deltaTime?
        // 이전 프레임에서 다음 프레임까지 걸린 시간 간격에 대한 읽기 전용 프로퍼티
        // 다른 PC와의 사양이 다르더라도 실행 결과가 다르지 않도록 하기 위해서
        //
        // 1번 PC : 1초 60 프레임 -> Time.deltaTime = 0.0166 -> 16.66
        // 2번 PC : 1초 30 프레임 -> Time.deltaTime = 0.0333 -> 33.33
        //
        // 1초 뒤에 1번 PC의 캐릭터가 이동한 거리 10(속도) * 60 = 600
        // 1초 뒤에 2번 PC의 캐릭터가 이동한 거리 10(속도) * 30 = 300
        //
        // 1초 뒤에 1번 PC의 캐릭터가 이동한 거리 10(속도) * 60 = 600 * 16.66 = 9996
        // 1초 뒤에 2번 PC의 캐릭터가 이동한 거리 10(속도) * 30 = 300 * 33.33 = 9999

    }
}
