using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class content_hide : MonoBehaviour
{
	public GameObject a, b, d;
	public void hidenow()
	{
		a.SetActive(false);
		b.SetActive(false);
		d.SetActive(true);
	}
}
