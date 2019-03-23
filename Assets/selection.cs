using UnityEngine;
using UnityEngine.UI;

public class selection : MonoBehaviour
{
	public Image spriteimage;
	public Image Image, check;
	private void select()
	{
		if(spriteimage == Image)
		{
			spriteimage = check;
		}
		else
		{
			spriteimage = Image;
		}
	}
}
