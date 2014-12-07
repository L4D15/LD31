﻿using UnityEngine;
using System.Collections;

public class PirateSceneItem : SceneItem {

	public override void Use (InventoryItem item)
	{
		if (m_state == 0)
		{
			// Initial State
            if (item is TigerInventoryItem)
            {

                // TODO
                // Play animation for loving the kitten

                base.Use(item);
                GameManager.GetInstance().GetComponent<Inventory>().RemoveItem(item);

                ++m_state;
                // Activates the canyon
                m_ItemToActivate.state++;
            }
            else
            {
                base.Use(null);
            }

		}
		else
		{
			// The pirate is busy loving the kitten
            base.Use(item);
		}
	}
}
