using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarAnimHandler : MonoBehaviour
{
    public Animator CarAnimator;
    public Button btnTyre, btnSeats, btnTop;
    private bool boolTyre, boolSeats, boolTop = false;

    public void AnimTyre()
    {
        if (!boolTyre)
        {
            boolTyre = true;
            CarAnimator.SetBool("boolTyre", boolTyre);
            btnTyre.GetComponent<Transform>().localScale = new Vector3(1.1f,1.1f,1.1f);
            btnTop.GetComponent<Transform>().localScale = new Vector3(0.9f, 0.9f, 0.9f);
            btnSeats.GetComponent<Transform>().localScale = new Vector3(0.9f, 0.9f, 0.9f);

            CarAnimator.SetBool("boolSeats", false);
            CarAnimator.SetBool("boolTop", false);
        }
        else {
            boolTyre = false;
            btnTyre.GetComponent<Transform>().localScale = new Vector3(0.9f, 0.9f, 0.9f);
            btnTop.GetComponent<Transform>().localScale = new Vector3(0.9f, 0.9f, 0.9f);
            btnSeats.GetComponent<Transform>().localScale = new Vector3(0.9f, 0.9f, 0.9f);

            CarAnimator.SetBool("boolTyre", false);
            CarAnimator.SetBool("boolSeats", false);
            CarAnimator.SetBool("boolTop", false);
        }
    }

    public void AnimSeats()
    {
        if (!boolSeats)
        {
            boolSeats = true;
            btnSeats.GetComponent<Transform>().localScale = new Vector3(1.1f, 1.1f, 1.1f);
            btnTyre.GetComponent<Transform>().localScale = new Vector3(0.9f, 0.9f, 0.9f);
            btnTop.GetComponent<Transform>().localScale = new Vector3(0.9f, 0.9f, 0.9f);

            CarAnimator.SetBool("boolTyre", false);
            CarAnimator.SetBool("boolSeats", boolSeats);
            CarAnimator.SetBool("boolTop", false);
        }
        else {
            boolSeats = false;
            btnSeats.GetComponent<Transform>().localScale = new Vector3(0.9f, 0.9f, 0.9f);
            btnTyre.GetComponent<Transform>().localScale = new Vector3(0.9f, 0.9f, 0.9f);
            btnTop.GetComponent<Transform>().localScale = new Vector3(0.9f, 0.9f, 0.9f);

            CarAnimator.SetBool("boolSeats", false);
            CarAnimator.SetBool("boolTyre", false);
            CarAnimator.SetBool("boolTop", false);
        }
    }

    public void AnimTop()
    {
        if (!boolTop)
        {
            boolTop = true;
            btnTop.GetComponent<Transform>().localScale = new Vector3(1.1f, 1.1f, 1.1f);
            btnSeats.GetComponent<Transform>().localScale = new Vector3(0.9f, 0.9f, 0.9f);
            btnTyre.GetComponent<Transform>().localScale = new Vector3(0.9f, 0.9f, 0.9f);

            CarAnimator.SetBool("boolTyre", false);
            CarAnimator.SetBool("boolSeats", false);
            CarAnimator.SetBool("boolTop", boolTop);
        }
        else {
            boolTop = false;
            btnTop.GetComponent<Transform>().localScale = new Vector3(0.9f, 0.9f, 0.9f);
            btnSeats.GetComponent<Transform>().localScale = new Vector3(0.9f, 0.9f, 0.9f);
            btnTyre.GetComponent<Transform>().localScale = new Vector3(0.9f, 0.9f, 0.9f);

            CarAnimator.SetBool("boolTop", false);
            CarAnimator.SetBool("boolTyre", false);
            CarAnimator.SetBool("boolSeats", false);
        }
    }
}
