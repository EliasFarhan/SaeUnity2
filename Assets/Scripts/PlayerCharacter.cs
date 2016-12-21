using UnityEngine;
using System.Collections;

namespace SaeUnity
{
	public class PlayerCharacter : MonoBehaviour {

		[SerializeField]float speed;
		[SerializeField] bool isTurnedRight = true;
		[SerializeField] SpriteRenderer m_SpriteRenderer;

		const float jumpVelocity = 5.0f;

		[SerializeField] float debugVelocity = 0.0f;
		Rigidbody2D m_Body;
		[SerializeField] Foot m_Foot;
		bool m_Grounded = false;

		int doubleJump = 0;

		void Awake()
		{
			m_Body = GetComponent<Rigidbody2D> ();
			transform.FindChild ("Foot").GetComponent<Foot> ();
		}
		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			debugVelocity = m_Body.velocity.y;

			m_Grounded = m_Foot.nmbOfGround > 0;
			if (m_Grounded)
				doubleJump = 1;
		}
		void FixedUpdate()
		{
			
		}
		public void Move(float horizontal, bool jump)
		{
			//m_Body.velocity = new Vector2(speed*horizontal, m_Body.velocity.y); DOES NOT CHANGE THE Y-VELOCITY
			//m_Body.velocity = new Vector2(speed*horizontal, 0.0f); DOES CHANGE THE Y-VELOCITY TO ZERO
			m_Body.velocity = new Vector2(speed*horizontal, m_Body.velocity.y);

			if (horizontal > 0 && !isTurnedRight) {
				Flip ();
			} else if (horizontal < 0 && isTurnedRight) {
				Flip ();
			}

			if (jump && (m_Grounded || doubleJump == 1)) {
				m_Body.velocity = new Vector2 (m_Body.velocity.x, jumpVelocity);	
				if (!m_Grounded) {
					doubleJump--;
				}
			}
				
		}

		void Flip()
		{
			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;

			//m_SpriteRenderer.flipX = !m_SpriteRenderer.flipX;

			isTurnedRight = !isTurnedRight;
		}
	}
}