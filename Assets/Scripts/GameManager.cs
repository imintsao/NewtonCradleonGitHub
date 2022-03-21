//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class GameManager : MonoBehaviour
//{
//    GameObject rightBeam;
//    GameObject leftBeam;
//    float zGap = 4f;
//    int duoRodTotal;

//    GameObject[] rodArray;

//    void Start()
//    {
//        CreateMainBeam();
//        CreateMainBeam(zGap);
//        duoRodTotal = 2;

//        rodArray = new GameObject[duoRodTotal];
//        for (int i = 0; i < duoRodTotal; i++)
//        {
//            rodArray[i] = SetRod();


//        }

//    }

//    private void CreateMainBeam()
//    {
//        rightBeam = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
//        rightBeam.transform.Rotate(0f, 0f, 90.0f);

//    }
//    private void CreateMainBeam(float zDistance)
//    {
//        leftBeam = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
//        leftBeam.transform.Rotate(0f, 0f, 90.0f);
//        leftBeam.transform.position = new Vector3(0f, 0f, zDistance);
//    }

//    private GameObject[] SetRod()
//    {
//        //GameObject refDuoRod;
//        GameObject[] refRod;
//        int rodCount = 2;
//        refRod = new GameObject[rodCount];
//        float yGap;
//        yGap = leftBeam.transform.position.y - leftBeam.transform.localScale.x / 2;

//        Rigidbody rodRB;
//        Rigidbody rightBeamRB;
//        Rigidbody leftBeamRB;
//        HingeJoint rodHJ;

//        for (int i = 0; i < rodCount; i++)
//        {
//            refRod[i] = GameObject.CreatePrimitive(PrimitiveType.Capsule);
//            refRod[i].transform.position = new Vector3(0f, yGap - refRod[i].transform.localScale.y, zGap * i);
//            rodHJ = refRod[i].AddComponent<HingeJoint>();
//            //return refRod[i];

//        }

//        return refRod;

//    }
//}
