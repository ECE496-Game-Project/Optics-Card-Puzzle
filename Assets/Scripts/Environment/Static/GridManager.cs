using UnityEngine;
using System.Collections;
using Optics.Utils;

public class GridManager : MonoSingleton<GridManager>
{
	[SerializeField] private int _width, _height;
	[SerializeField] private Tile _tilePrefab;

	public void GenerateGrid()
	{
		for(int col = 0; col < _width; col++)
		{
			for(int row = 0; row < _height; row++)
			{
				var spwanedTile = Instantiate(_tilePrefab, new Vector3(col, row), Quaternion.identity);
				spwanedTile.name = $"Tile_{col}_{row}";
				spwanedTile.transform.SetParent(gameObject.transform);
            }
		}

		Vector3 midPoint = new Vector3((float)_width / 2 - 0.5f, (float)_height / 2 - 0.5f, -10f);
		CameraManager.Instance.followPoint.position = midPoint;
	}
}

