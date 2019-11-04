using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.MixedReality.Toolkit;
using Services;
using TMPro;
using UnityEngine;

public class NamesReader : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro _text;

    private IDataService _dataService;
    void Start()
    {
        _dataService = MixedRealityToolkit.Instance.GetService<IDataService>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            LoadNames();

        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _text.text = "";
        }
    }

    private async Task LoadNames()
    {
        try
        {
            var names = await _dataService.GetNames();
            _text.text = string.Join(Environment.NewLine, names.Select(p => $"{p.FirstName} {p.LastName}"));
        }
        catch (Exception ex)
        {
            Debug.Log(ex);
        }
    }
}
