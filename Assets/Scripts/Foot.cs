using UnityEngine;
using System.Collections;

namespace SaeUnity
{
	public class Foot : MonoBehaviour {

		public int nmbOfGround = 0;

		void OnCollideEnter2D(Collision2D collision)
		{
			//Two solid objects non-kinemtic
		}
		void OnCollideExit2D(Collision2D collision)
		{
			//Two solid objects non-kinemtic
		}
		void OnTriggerEnter2D(Collider2D collider)
		{
			//Solid and trigger, or two trigger colliders

			if (collider.gameObject.layer == LayerMask.NameToLayer ("Ground")) {
				nmbOfGround++;
			}
		}
		void OnTriggerExit2D(Collider2D collider)
		{
			//Is not called when one of the objects is destroyed before
			if (collider.gameObject.layer == LayerMask.NameToLayer ("Ground")) {
				nmbOfGround--;
			}
		}
	}
}