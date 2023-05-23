using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;

namespace ucmdb_mvc.Models
{
				public class Machine
				{
								public int Id { get; set; }
								public string Nickname
								{
												get; set;
								}
								
								public string Manufacturer
								{
												get; set;
								}
								public string Description
								{
												get; set;
								}

								public string? IP_Address
								{
												get; set;
								}

								public string? SubnetMask
								{
												get; set;
								}

								public string? Gateway
								{
												get; set;
								}

								public string Arch
								{
												get; set;
								}
								
								public string ModelName
								{
												get; set;
								}

								public int? StorageGbs
								{
												get; set;
								}
				}
}
