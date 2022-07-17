using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
	public Action Move;
	public event Action MoveSomeThing;
	public Action<int> b = s => Console.WriteLine(1);
	private Vector3 a;
	// Start is called before the first frame update

	int[,] array = new int[4, 3] { { 1, 1, 1 }, { 0, 0, 0 }, { 2, 2, 2 }, { 3, 3, 3 } };
	int[][] array1 = new int[4][] { new int[3], new int[3], new int[3], new int[3] };
	void Start()
	{
		Move += MoveSphere;
		//Move += BackMoveSphere;
		//Move.Invoke();
		a = this.transform.position;
		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < 3; j++)
			{
				array1[i][j] = array[i, j];
			}
		}
	}
	public void MoveSphere()
	{
		this.transform.position = new Vector3(1, 1, 1);
	}
	public void BackMoveSphere()
	{
		this.transform.position = new Vector3(2, 2, 2);
	}
	public

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.W))
		{
			Debug.Log("移动事件触发了");
			Action<int> c = s => Debug.Log(666);
			c.Invoke(666);
			//Move?.Invoke();
			//Move -= MoveSphere;
		}
		if (Input.GetKeyDown(KeyCode.A))
		{
			Debug.Log("物体回归原位");
			this.transform.position = a;
		}
		if (Input.GetKeyDown(KeyCode.S))
		{
			Debug.Log("移动事件移除了");
			//Move -= MoveSphere;
			Move = null;
			Debug.Log(Move == null);
		}
		if (Input.GetKeyDown(KeyCode.D))
		{
			///aaa(1,d);
			aaa(1, (s) =>
			{
				Debug.Log(s);
			});
		}
		if (Input.GetKeyDown(KeyCode.Q))
		{
			TestAciton((s) =>
			{
				Debug.Log(s);
			});
		}
	}
	public void TestAciton(Action<int> a)
	{
		a(1000);
	}
	public void aaa(int b, Action<int> c)
	{
		b = b + 1;
		c(b);
	}
	public void d(int d)
	{
		Debug.Log(d);
	}

	internal void OnRelease()
	{
		while(true)
		{

		}
	}
}
