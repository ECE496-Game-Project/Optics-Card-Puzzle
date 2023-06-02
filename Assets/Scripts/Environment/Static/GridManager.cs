using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Optics.Utils;

public class GridManager : MonoSingleton<GridManager>
{
	[SerializeField] private int _width, _height;
	[SerializeField] private Tile _tilePrefab;
	private Vector3 _midPoint;
    private Dictionary<Vector2, Tile> _tiles;

    private void Awake()
    {
        _midPoint = new Vector3((float)_width / 2 - 0.5f, (float)_height / 2 - 0.5f);
    }

    public void GenerateGrid()
	{
		_tiles = new Dictionary<Vector2, Tile>();

		for(int col = 0; col < _width; col++)
		{
			for(int row = 0; row < _height; row++)
			{
				var spwanedTile = Instantiate(_tilePrefab, new Vector3(col, row, 1f), Quaternion.identity);
				spwanedTile.name = $"Tile_{col}_{row}";
				spwanedTile.transform.SetParent(gameObject.transform);

				_tiles[new Vector2(col, row)] = spwanedTile;
            }
		}

		CameraManager.Instance.followPoint.position = _midPoint;
	}

	public Tile GetTileAtPosition(Vector2 pos)
	{
		if (_tiles.TryGetValue(pos, out var tile)) return tile;
		return null;
	}
}

