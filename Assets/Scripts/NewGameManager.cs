using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGameManager : MonoBehaviour
{
    GameObject leftBeam;
    GameObject rightBeam;
    float zGap = 2.6f;
    float yGap;
    GameObject[] sphereArray;

    Rigidbody beamRB;

    float tempRadius;


    int cradleCount;



    struct TwinRods
    {
        public float setNumber;
        public GameObject lRod;
        public GameObject rRod;

    }

    private TwinRods SetRods(float setNum)
    {
        GameObject lRod, rRod;
        TwinRods refRods;
        //float yGap;
        //yGap = leftBeam.transform.position.y - leftBeam.transform.localScale.x / 2;
        HingeJoint rodHJ;
        Rigidbody rodRB;

        lRod = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        lRod.name = "LeftRod";
        rRod = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        rRod.name = "RightRod";

        lRod.transform.localScale = new Vector3(0.1f, 1.5f, 0.1f);
        lRod.transform.position = new Vector3(0f, yGap - lRod.transform.localScale.y, 0f);
        rodHJ=lRod.AddComponent<HingeJoint>();
        rodHJ.connectedBody = beamRB;
        rodHJ.axis = new Vector3(0f, 0f, 1f);
        //lRod.transform.parent = leftBeam.transform;

        rodRB = lRod.GetComponent<Rigidbody>();
        rodRB.useGravity = (true);
        rodRB.isKinematic = (false);


        rRod.transform.localScale = new Vector3(0.1f, 1.5f, 0.1f);
        rRod.transform.position = new Vector3(0f, yGap - rRod.transform.localScale.y, zGap);
        rRod.AddComponent<HingeJoint>();



        refRods.lRod = lRod;
        refRods.rRod = rRod;
        refRods.setNumber = setNum;

        return refRods;

    }

    private void Start()
    {

        CreateMainBeam();
        CreateMainBeam(zGap);
        yGap = leftBeam.transform.position.y - leftBeam.transform.localScale.x / 2;


        TwinRods[] rodArray;

        cradleCount = 1;

        rodArray = new TwinRods[cradleCount];

        tempRadius = 0.5f;
        sphereArray = new GameObject[cradleCount];

        for (int i = 0; i < cradleCount; i++)
        {
            rodArray[i] = SetRods(i);
            sphereArray[i] = SetSphere(rodArray[i]);

        }
    }

    private void CreateMainBeam()
    {
        leftBeam = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        leftBeam.transform.Rotate(0f, 0f, 90.0f);

        beamRB = leftBeam.AddComponent<Rigidbody>();
        beamRB.useGravity = (false);
        beamRB.isKinematic = (true);
        leftBeam.name = "LeftBeam";

        //leftBeam.transform.rotation = Quaternion.Euler(-30f, 0f, 0f);
        //leftBeam.transform.Rotate(-30f, 0f, 0f, Space.World);
        //rightBeam.transform.position=new Vector3(0f,)

    }
    private void CreateMainBeam(float zDistance)
    {
        rightBeam = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        rightBeam.transform.Rotate(0f, 0f, 90.0f);
        rightBeam.transform.position = new Vector3(0f, 0f, zDistance);
        rightBeam.name = "RightBeam";
        
    }



    private GameObject SetSphere(TwinRods referenceRod)
    {
        GameObject refBall;
        //float yGap;
        //refYGap= leftBeam.transform.position

        refBall = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        refBall.transform.localScale = new Vector3(tempRadius, tempRadius, tempRadius);
        refBall.name = "Cradle";
        //refBall.transform.position = new Vector3(leftBeam.transform.position.x,yGap-referenceRod.)




        return refBall;
    }


}
