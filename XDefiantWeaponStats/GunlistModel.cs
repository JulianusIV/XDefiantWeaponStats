using System.Text.Json;
using System.Text.Json.Serialization;

namespace XDefiantWeaponStats
{
    public class GunlistModel
    {
        public static List<ClassModel> JsonObject 
        { 
            get => _jsonObject ??= JsonSerializer.Deserialize<List<ClassModel>>(JSON_STRING)!;
        }

        private static List<ClassModel>? _jsonObject;
        private const string JSON_STRING = """
            [
                {
                    "class": "Assault",
                    "guns": [
                        {
                            "name": "M16A4",
                            "ranges": [
                                34,
                                45,
                                300
                            ],
                            "base_dmg": [
                                24,
                                21,
                                17
                            ],
                            "crit_dmg": [
                                37,
                                33,
                                26
                            ],
                            "rof": 275,
                            "shots_per_trigger": 3
                        },
                        {
                            "name": "MDR",
                            "ranges": [
                                23,
                                35,
                                300
                            ],
                            "base_dmg": [
                                17,
                                16,
                                14
                            ],
                            "crit_dmg": [
                                24,
                                22,
                                20
                            ],
                            "rof": 765,
                            "shots_per_trigger": 1
                        },
                        {
                            "name": "M4A1",
                            "ranges": [
                                38,
                                50,
                                300
                            ],
                            "base_dmg": [
                                17,
                                16,
                                14
                            ],
                            "crit_dmg": [
                                24,
                                22,
                                20
                            ],
                            "rof": 725,
                            "shots_per_trigger": 1
                        },
                        {
                            "name": "AK-47",
                            "ranges": [
                                29,
                                43,
                                300
                            ],
                            "base_dmg": [
                                22,
                                20,
                                18
                            ],
                            "crit_dmg": [
                                33,
                                30,
                                27
                            ],
                            "rof": 600,
                            "shots_per_trigger": 1
                        },
                        {
                            "name": "ACR",
                            "ranges": [
                                33,
                                45,
                                300
                            ],
                            "base_dmg": [
                                21,
                                19,
                                17
                            ],
                            "crit_dmg": [
                                29,
                                27,
                                24
                            ],
                            "rof": 625,
                            "shots_per_trigger": 1
                        }
                    ]
                },
                {
                    "class": "SMG",
                    "guns": [
                        {
                            "name": "Vector .45 ACP",
                            "ranges": [
                                13,
                                19,
                                100
                            ],
                            "base_dmg": [
                                19,
                                11,
                                8
                            ],
                            "crit_dmg": [
                                23,
                                13,
                                10
                            ],
                            "rof": 1000,
                            "shots_per_trigger": 1
                        },
                        {
                            "name": "P90",
                            "ranges": [
                                18,
                                24,
                                100
                            ],
                            "base_dmg": [
                                18,
                                13,
                                10
                            ],
                            "crit_dmg": [
                                24,
                                18,
                                14
                            ],
                            "rof": 825,
                            "shots_per_trigger": 1
                        },
                        {
                            "name": "MP7",
                            "ranges": [
                                17,
                                22,
                                100
                            ],
                            "base_dmg": [
                                19,
                                11,
                                8
                            ],
                            "crit_dmg": [
                                23,
                                13,
                                10
                            ],
                            "rof": 875,
                            "shots_per_trigger": 1
                        },
                        {
                            "name": "MP5A2",
                            "ranges": [
                                16,
                                25,
                                100
                            ],
                            "base_dmg": [
                                18,
                                13,
                                10
                            ],
                            "crit_dmg": [
                                24,
                                18,
                                14
                            ],
                            "rof": 800,
                            "shots_per_trigger": 1
                        }
                    ]
                },
                {
                    "class": "LMG",
                    "guns": [
                        {
                            "name": "RPK-74",
                            "ranges": [
                                36,
                                48,
                                300
                            ],
                            "base_dmg": [
                                23,
                                21,
                                20
                            ],
                            "crit_dmg": [
                                32,
                                29,
                                28
                            ],
                            "rof": 525,
                            "shots_per_trigger": 1
                        },
                        {
                            "name": "M60",
                            "ranges": [
                                38,
                                50,
                                300
                            ],
                            "base_dmg": [
                                25,
                                23,
                                20
                            ],
                            "crit_dmg": [
                                35,
                                32,
                                28
                            ],
                            "rof": 500,
                            "shots_per_trigger": 1
                        },
                        {
                            "name": "M249",
                            "ranges": [
                                31,
                                42,
                                300
                            ],
                            "base_dmg": [
                                23,
                                20,
                                18
                            ],
                            "crit_dmg": [
                                32,
                                28,
                                25
                            ],
                            "rof": 600,
                            "shots_per_trigger": 1
                        }
                    ]
                },
                {
                    "class": "Marksman",
                    "guns": [
                        {
                            "name": "SVD",
                            "ranges": [
                                45,
                                70,
                                300
                            ],
                            "base_dmg": [
                                49,
                                47,
                                45
                            ],
                            "crit_dmg": [
                                98,
                                94,
                                90
                            ],
                            "rof": 185,
                            "shots_per_trigger": 1
                        },
                        {
                            "name": "MK 20 SSR",
                            "ranges": [
                                40,
                                60,
                                300
                            ],
                            "base_dmg": [
                                49,
                                43,
                                41
                            ],
                            "crit_dmg": [
                                88,
                                77,
                                73
                            ],
                            "rof": 200,
                            "shots_per_trigger": 1
                        }
                    ]
                },
                {
                    "class": "Sidearm",
                    "guns": [
                        {
                            "name": "686 Magnum",
                            "ranges": [
                                10,
                                30,
                                60
                            ],
                            "base_dmg": [
                                48,
                                44,
                                34
                            ],
                            "crit_dmg": [
                                96,
                                88,
                                68
                            ],
                            "rof": 150,
                            "shots_per_trigger": 1
                        },
                        {
                            "name": "M1911",
                            "ranges": [
                                10,
                                20,
                                50
                            ],
                            "base_dmg": [
                                30,
                                24,
                                18
                            ],
                            "crit_dmg": [
                                48,
                                38,
                                29
                            ],
                            "rof": 335,
                            "shots_per_trigger": 1
                        },
                        {
                            "name": "D50",
                            "ranges": [
                                10,
                                30,
                                50
                            ],
                            "base_dmg": [
                                45,
                                33,
                                24
                            ],
                            "crit_dmg": [
                                90,
                                66,
                                48
                            ],
                            "rof": 200,
                            "shots_per_trigger": 1
                        },
                        {
                            "name": "93R",
                            "ranges": [
                                10,
                                20,
                                50
                            ],
                            "base_dmg": [
                                17,
                                15,
                                13
                            ],
                            "crit_dmg": [
                                31,
                                27,
                                23
                            ],
                            "rof": 350,
                            "shots_per_trigger": 3
                        },
                        {
                            "name": "M9",
                            "ranges": [
                                10,
                                20,
                                50
                            ],
                            "base_dmg": [
                                24,
                                20,
                                15
                            ],
                            "crit_dmg": [
                                38,
                                32,
                                24
                            ],
                            "rof": 400,
                            "shots_per_trigger": 1
                        }
                    ]
                }
            ]
            """;
    }

    public class ClassModel
    {
        [JsonPropertyName("class")]
        public string? Class { get; set; }
        [JsonPropertyName("guns")]
        public GunModel[]? Guns { get; set; }
    }

    public class GunModel
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("ranges")]
        public int[]? Ranges { get; set; }
        [JsonPropertyName("base_dmg")]
        public int[]? BaseDmg { get; set; }
        [JsonPropertyName("crit_dmg")]
        public int[]? CritDmg { get; set; }
        [JsonPropertyName("rof")]
        public int Rof { get; set; }
        [JsonPropertyName("shots_per_trigger")]
        public int ShotsPerTrigger { get; set; }
        public bool Checked { get; set; } = false;
    }
}
