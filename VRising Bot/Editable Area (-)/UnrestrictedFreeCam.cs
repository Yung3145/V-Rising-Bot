using System;
using UnityEngine;
using VRising.ESP;
using ProjectM;

// Token: 0x02000015 RID: 21
public class UnrestrictedFreeCam : MonoBehaviour
{
	// Token: 0x0600007B RID: 123 RVA: 0x0000447C File Offset: 0x0000267C
	private void Start()
	{
		if (!this.freeCamCamera)
		{
			this.freeCamCamera = Camera.main;
		}
		if (!this.freeCamCamera)
		{
			Debug.LogWarning("Kamera bulunamadı! Lütfen freeCamCamera referansını ayarlayın.");
		}
		this.yaw = this.freeCamCamera.transform.eulerAngles.y;
		this.pitch = this.freeCamCamera.transform.eulerAngles.x;
	}

	// Token: 0x0600007C RID: 124 RVA: 0x000044F4 File Offset: 0x000026F4
	private void Update()
	{
		if (!this.freeCamCamera)
		{
			return;
		}
		float d = (float)(Input.GetKey(KeyCode.W) ? 1 : (Input.GetKey(KeyCode.S) ? -1 : 0));
		float d2 = (float)(Input.GetKey(KeyCode.D) ? 1 : (Input.GetKey(KeyCode.A) ? -1 : 0));
		float d3 = (float)(Input.GetKey(KeyCode.Space) ? 1 : (Input.GetKey(KeyCode.LeftControl) ? -1 : 0));
		Vector3 a = this.freeCamCamera.transform.forward * d + this.freeCamCamera.transform.right * d2 + this.freeCamCamera.transform.up * d3;
		this.freeCamCamera.transform.position += a * this.moveSpeed * Time.deltaTime;
		if (Input.GetKey(this.freeLookKey))
		{
			float num = Input.GetAxis("Mouse X") * this.lookSensitivity;
			float num2 = Input.GetAxis("Mouse Y") * this.lookSensitivity;
			this.yaw += num;
			this.pitch -= num2;
			this.pitch = Mathf.Repeat(this.pitch, 360f);
			this.yaw = Mathf.Repeat(this.yaw, 360f);
			this.freeCamCamera.transform.rotation = Quaternion.Euler(this.pitch, this.yaw, 0f);
		}
	}

	// Token: 0x04000052 RID: 82
	public Camera freeCamCamera;

	// Token: 0x04000053 RID: 83
	public float moveSpeed = 10f;

	// Token: 0x04000054 RID: 84
	public float lookSensitivity = 2f;

	// Token: 0x04000055 RID: 85
	public KeyCode freeLookKey = KeyCode.Mouse1;

	// Token: 0x04000056 RID: 86
	private float yaw;

	// Token: 0x04000057 RID: 87
	private float pitch;
}
