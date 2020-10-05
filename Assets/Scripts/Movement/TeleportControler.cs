using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class TeleportEvent : UnityEvent<Vector3>
{
}

public class TeleportControler : MonoBehaviour
{
	public TeleportEvent teleportEvent;

	void Start()
	{
		if (teleportEvent == null)
		{
			teleportEvent = new TeleportEvent();
		}
	}

	public void TeleportTo(BaseEventData data)
	{
		PointerEventData pointerData = data as PointerEventData;
		Vector3 worldPos = pointerData.pointerCurrentRaycast.worldPosition;
		teleportEvent.Invoke(worldPos);
	}
}

