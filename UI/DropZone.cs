using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

	public Draggable.Slot typeOfCard = Draggable.Slot.INVENTORY;
	
	public void OnPointerEnter(PointerEventData eventData) {
		if(eventData.pointerDrag == null){
			return;
		}
		
		Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
		if(d != null) {
			d.placeholderParent = this.transform;
		}
	}
	
	public void OnPointerExit(PointerEventData eventData) {
		if (eventData.pointerDrag == null) {
			return;
		}
		
		Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
		if(d != null && d.placeholderParent==this.transform) {
			d.placeholderParent = d.parentToReturnTo;
		}
	}
	
	public void OnDrop(PointerEventData eventData) {		
		Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
		if(d != null) {
			if (typeOfCard == d.typeOfCard || typeOfCard == Draggable.Slot.DECK || typeOfCard == Draggable.Slot.HOLDER) {
				d.parentToReturnTo = this.transform;
			}
		}
		
	}
}