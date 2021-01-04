﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace MinimumCostToConnectSticks
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] arr = new int[]
            {
                8471, 4944, 1488, 3935, 6725, 6025, 3848, 4138, 2541, 4045, 3702, 1717, 8453, 7933, 8805, 1469, 652, 4438, 5906, 3792, 1162, 1383, 9588, 7076, 2155, 1817, 8559, 2642, 5602, 2094, 3478, 2549, 3457, 1341, 334, 6526, 7922, 9518, 9044, 856, 4319, 7161, 2488, 9683, 3006, 2331, 1927, 3439, 7533, 6843, 7809, 6903, 9055, 7076, 6421, 7770, 2938, 9031, 6869, 3810, 3676, 4854, 8241, 4435, 3091, 3718, 7372, 9977, 7448, 830, 2318, 6537, 6213, 9045, 6957, 5183, 7542, 4759, 5887, 6728, 9619, 3728, 8792, 7519, 2664, 2895, 5394, 8311, 7366, 9808, 4163, 3142, 3087, 1572, 6419, 6384, 1671, 1419, 7843, 3384, 867, 7002, 8211, 1952, 7542, 511, 6231, 9926, 7472, 3864, 1411, 8562, 7024, 7436, 1667, 4936, 6472, 6523, 898, 461, 365, 3305, 2498, 7604, 5336, 4664, 1687, 6546, 4653, 1295, 414, 8724, 466, 5891, 5386, 8721, 3863, 9588, 8591, 1212, 4508, 2704, 8993, 2829, 2789, 890, 352, 4664, 203, 503, 2337, 3861, 548, 2791, 886, 5343, 8410, 7126, 5298, 8655, 9555, 8130, 2036, 5951, 728, 4058, 5263, 9579, 6520, 6406, 9888, 7866, 7347, 8828, 3516, 6499, 8808, 7087, 7391, 1067, 2066, 3741, 7721, 5194, 4663, 9544, 3668, 1742, 6030, 3705, 4208, 405, 4034, 7517, 6528, 8995, 6185, 5924, 6678, 5639, 6725, 6776, 5132, 5686, 1607, 8327, 975, 7171, 4126, 4169, 2562, 2742, 6605, 2625, 711, 1074, 6651, 8225, 1125, 5438, 5457, 5367, 6726, 206, 4226, 4327, 3412, 7587, 9246, 8288, 6590, 1591, 6479, 2366, 7492, 802, 8793, 6708, 6271, 8898, 535, 5871, 4186, 3361, 5884, 1418, 5082, 3838, 4034, 8259, 2061, 3663, 9708, 3881, 5084, 3380, 7426, 571, 6877, 2243, 1121, 1993, 2513, 2243, 9822, 8188, 2748, 7752, 1769, 8237, 1961, 1321, 919, 3927, 4146, 9866, 5043, 5184, 6588, 2745, 2231, 2758, 6598, 2707, 3382, 5931, 3097, 8110, 4292, 10, 4526, 2141, 6677, 9621, 3991, 7614, 6628, 9649, 5186, 5881, 9872, 2881, 7957, 6343, 3640, 5236, 1527, 5809, 3139, 7441, 2745, 4620, 7909, 1218, 6705, 1413, 659, 565, 6291, 6103, 5616, 8789, 3948, 8052, 4290, 9948, 7014, 9123, 30, 2343, 3187, 5352, 9831, 3350, 8600, 815, 7414, 4618, 9483, 6807, 308, 6513, 333, 6149, 6701, 3056, 6567, 6413, 1832, 7088, 4651, 442, 7831, 4996, 508, 5593, 353, 4872, 6926, 9188, 5247, 9555, 611, 4833, 2016, 2101, 7313, 8219, 6014, 4716, 2718, 6315, 3774, 3759, 9367, 3604, 1956, 5093, 7644, 9500, 8480, 4121, 2402, 2318, 2410, 2978, 289, 3606, 8790, 513, 7206, 9513, 3498, 7004, 8149, 309, 678, 3381, 2298, 3082, 5530, 2303, 519, 3491, 2533, 6962, 7135, 2411, 1359, 4913, 7388, 3621, 1569, 6243, 7106, 627, 8953, 8944, 8032, 4516, 2708, 9242, 3673, 6631, 4062, 4846, 6906, 1003, 4333, 7825, 5399, 459, 6082, 4998, 7221, 7746, 3077, 4986, 4873, 1369, 4978, 2412, 9864, 9223, 4573, 1807, 1194, 17, 8650, 2828, 3464, 6594, 5661, 8057, 187, 5823, 3003, 1198, 7893, 5772, 8993, 173, 4828, 1168, 7915, 3951, 6534, 9457, 4653, 8323, 5411, 635, 7205, 7964, 1169, 3100, 9415, 4948, 6724, 1666, 9388, 7440, 245, 384, 8352, 4548, 9314, 8117, 7542, 277, 1949, 7164, 4294, 971, 7166, 7433, 5803, 1259, 8501, 5286, 9117, 950, 4967, 7961, 3216, 1729, 4529, 1814, 9012, 4998, 4657, 93, 9362, 6953, 8302, 895, 1180, 3090, 7847, 739, 1711, 7928, 2367, 7622, 5411, 3507, 1151, 9174, 5997, 5007, 8657, 7499, 1664, 5962, 6027, 6950, 5129, 4083, 354, 5461, 483, 2986, 2044, 6242, 4440, 9614, 7111, 5380, 7942, 2512, 4510, 2072, 994, 6549, 3301, 7702, 5901, 3229, 2078, 4619, 7487, 2249, 4318, 9442, 7111, 3657, 2900, 9682, 1917, 9158, 5729, 5836, 7595, 2947, 4707, 8043, 8318, 2490, 2559, 8583, 3512, 5601, 7885, 1337, 9684, 4165, 2321, 9448, 8146, 6732, 6544, 1607, 6137, 3524, 6078, 3792, 1168, 9907, 6861, 7985, 8178, 8625, 373, 6860, 8157, 4975, 4763, 7203, 4498, 45, 4839, 7824, 1248, 439, 8490, 8378, 2648, 8895, 4471, 7005, 2672, 8136, 4084, 4378, 3796, 2663, 251, 5542, 2780, 5825, 5227, 1563, 7685, 3029, 7958, 9283, 8303, 7686, 2793, 4265, 1162, 1948, 7090, 6573, 274, 3502, 2789, 9785, 8466, 5269, 9868, 5864, 5931, 7810, 6273, 7864, 9395, 607, 1707, 3097, 5663, 6141, 3179, 7502, 1347, 4106, 9167, 8682, 9823, 9416, 7527, 3686, 2923, 1261, 2664, 8845, 2111, 2374, 5282, 5524, 378, 4681, 9044, 9328, 7420, 612, 7235, 3274, 8047, 8801, 3979, 3876, 7775, 6045, 4881, 4492, 3869, 815, 2046, 9328, 5534, 9793, 9359, 3492, 9090, 2174, 4626, 3361, 4367, 1285, 154, 7136, 3658, 1890, 5448, 4068, 2884, 9568, 9473, 8790, 7524, 3285, 1214, 168, 1698, 6046, 5414, 6672, 7700, 3270, 8973, 8357, 405, 9720, 3409, 1928, 4633, 1292, 9824, 4572, 197, 7579, 6671, 515, 4860, 2643, 6974, 8175, 913, 1370, 4477, 441, 9048, 4956, 6903, 5630, 2075, 6530, 316, 8022, 8071, 4993, 5422, 4612, 7970, 508, 1657, 5822, 8027, 7357, 3942, 5969, 534, 1898, 6895, 5564, 8633, 7926, 2619, 4174, 4520, 614, 2580, 7790, 7373, 2330, 3043, 6228, 7461, 7892, 6158, 2570, 9067, 2403, 7558, 5417, 4809, 7257, 6509, 2428, 4629, 9748, 4099, 565, 8768, 1435, 7649, 8082, 1091, 3228, 2792, 5586, 7350, 9468, 5608, 9794, 2913, 585, 8120, 2432, 8418, 6703, 1469, 1437, 6997, 5466, 7733, 3814, 5433, 6736, 2443, 9759, 1805, 6096, 9537, 7309, 4417, 7090, 4189, 3447, 4930, 1712, 1074, 742, 9422, 8348, 1491, 6845, 4773, 1671, 8544, 6882, 8924, 2590, 4546, 577, 4604, 1014, 5693, 7917, 6954, 5203, 3157, 3057, 720, 5873, 8702, 7834, 6534, 5861, 6014, 2867, 7989, 8454, 5863, 888, 3182, 5504, 5595, 7829, 7762, 8028, 5299, 9524, 4534, 18, 818, 7341, 5425, 7884, 4456, 8909, 2700, 1991, 7865, 6093, 2222, 5921, 5112, 8791, 8863, 7662, 4154, 3964, 9288, 6374, 1821, 8607, 5388, 9900, 6119, 4025, 1192, 1212, 3236, 4956, 3960, 5889, 7556, 3299, 3793, 9702, 3902, 5081, 3358, 1576, 6488, 2784, 211, 1789, 8557, 4243, 3818, 672, 1759, 9480, 7655, 1263, 7543, 8909, 5311, 1810, 9911, 6120, 7115, 1066, 7563, 1315, 8055, 5767, 6856, 3862, 4220, 8439, 2595, 3177, 4053, 4576, 7462, 267, 3064, 2352, 5260, 3086, 1155, 6888, 4399, 7043, 6020, 6550, 4407, 8547, 3916, 2062, 112, 8597, 5107, 7556, 9458, 7391, 835, 505, 3944, 3843, 4879, 2142, 14, 5099, 9833, 4488, 6323, 918, 9778, 9286, 3597, 2604, 3274, 4360, 4788, 7972, 6634, 8201, 682, 9294, 1739, 3065, 7875, 5157, 1191, 7795, 3829, 7504, 8277, 3999, 4620, 8060, 2851, 5137, 6682, 3206, 6454, 9783, 4918, 3081, 8402, 9253, 3662, 2958, 6358, 9327, 8727, 1668, 4942, 5325, 572, 888, 5570, 2702, 5927, 4256, 8874, 6808, 9807, 8625, 8003, 549, 6314, 8258, 4898, 1010, 8238, 421, 9984, 6420, 1810, 4036, 8762, 6202, 2206, 7644, 1845, 9090, 7783, 1656, 3629, 745, 6247, 9489, 3377, 8146, 171, 1041, 813, 5327, 4790, 4080, 3615, 4363, 5, 4930, 6545, 763, 6102, 4704, 587, 2469, 5244, 7125, 7521, 6871, 8780, 8077, 8708, 3717, 8946, 1554, 6788, 8216, 6822, 4401, 8762, 7758, 216, 9010, 3736, 2119, 5473, 742, 8432, 8613, 4147, 3801, 1156, 7313, 6980, 3979, 8238, 2157, 7994, 332, 327, 7067, 1407, 4131, 6832, 7410, 8224, 1238, 2864, 3969, 5901, 8754, 9367, 7140, 1677, 3165, 4281, 9810, 5630, 9027, 2439, 6474, 8042, 4314, 9956, 9241, 3769, 7231, 476, 1687, 3193, 4451, 9510, 7730, 978, 2337, 2907, 4311, 2343, 7109, 1241, 4671, 2987, 4277, 9264, 1132, 8991, 9296, 8027, 8639, 257, 3054, 2165, 5095, 8631, 5938, 5229, 165, 8661, 5874, 6144, 7345, 8314, 9062, 6735, 2498, 5462, 1387, 8087, 3534, 4725, 5788, 3865, 6186, 7461, 768, 8859, 6987, 5091, 8840, 2087, 3868, 8301, 7303, 198, 6214, 9475, 4146, 2975, 3606, 6212, 9490, 6361, 3194, 2264, 7764, 4496, 9154, 7472, 3472, 3313, 2862, 3678, 6165, 3560, 4081, 8855, 679, 9602, 6248, 9421, 7955, 3252, 1088, 1407, 3779, 9831, 4358, 305, 2721, 6427, 5035, 4668, 9675, 9074, 2762, 7331, 4722, 2054, 432, 3366, 1389, 1251, 6885, 3456, 5606, 2115, 4399, 6443, 8064, 597, 4802, 9893, 7767, 4749, 8483, 8997, 8353, 894, 5791, 4222, 6027, 613, 3272, 514, 5949, 3487, 1613, 4675, 3048, 3172, 6534, 2972, 3476, 2892, 9038, 1044, 2691, 3025, 2002, 9092, 1881, 9140, 3719, 2598, 9503, 5939, 7647, 1008, 3964, 7617, 7699, 1255, 4188, 7167, 1130, 5827, 630, 4449, 2133, 5213, 1183, 7001, 2150, 4613, 5832, 9078, 3027, 8770, 2902, 4568, 9322, 4012, 3541, 2613, 8044, 4533, 319, 7265, 5008, 3695, 1756, 72, 7645, 7957, 3526, 2420, 7910, 1145, 8832, 2579, 573, 8318, 5965, 5771, 3767, 9554, 9045, 4013, 6757, 1897, 602, 6849, 9093, 8291, 9699, 1994, 7268, 6755, 7777, 369, 5469, 4037, 2610, 8669, 6980, 9443, 3944, 3633, 2344, 1870, 204, 6264, 5260, 2238, 3281, 9163, 6959, 5849, 5874, 8368, 1745, 871, 2988, 3753, 5864, 6755, 8642, 6531, 8239, 4964, 734, 5044, 5653, 4054, 496, 7408, 2090, 7214, 5707, 9591, 9901, 5695, 9286, 9333, 1702, 1663, 1711, 4024, 7215, 4066, 3097, 3403, 5341, 5747, 5866, 3456, 1497, 871, 5211, 177, 804, 7229, 6958, 6653, 4288, 1184, 6847, 7018, 9315, 6780, 9105, 6885, 9533, 4088, 590, 3466, 1460, 4528, 3248, 4370, 3791, 1548, 470, 6497, 3919, 8807, 9159, 5714, 978, 8279, 2052, 6729, 5517, 7448, 5076, 5224, 2086, 9063, 1665, 1516, 1645, 5511, 1420, 4894, 2508, 3104, 7334, 4681, 5821, 6004, 7939, 181, 302, 3765, 3307, 6, 526, 6427, 1287, 6742, 443, 8447, 9854, 8397, 112, 6055, 2136, 3531, 5194, 6148, 908, 2784, 9476, 1149, 4520, 630, 7694, 490, 2019, 1106, 6555, 3555, 4447, 407, 3694, 3277, 4040, 7861, 3796, 8658, 1180, 9808, 6911, 489, 5951, 8588, 7431, 8511, 5231, 2657, 1736, 1139, 5608, 7895, 7822, 2737, 8405, 8861, 9253, 538, 5573, 8524, 5068, 1193, 3237, 448, 5312, 6943, 2988, 820, 5822, 918, 9740, 8268, 6250, 6486, 2417, 8719, 8785, 9939, 7020, 1998, 5726, 761, 6724, 6759, 1876, 7671, 8155, 275, 999, 9438, 8123, 9016, 3902, 2499, 3191, 4617, 4711, 6657, 956, 9005, 9161, 3463, 7637, 9687, 8753, 3662, 2886, 2746, 9425, 6087, 5063, 5861, 1157, 497, 8957, 4124, 9520, 146, 1698, 3000, 5500, 3045, 5739, 2541, 6834, 6519, 197, 6475, 3045, 4468, 8486, 1978, 6690, 8987, 4705, 6495, 1850, 223, 8181, 3290, 8819, 5106, 4474, 2430, 9153, 7321, 2175, 8512, 5404, 7075, 6774, 638, 7285, 6484, 9400, 8811, 7094, 2552, 1467, 1642, 3877, 1994, 1792, 828, 8951, 7146, 3591, 6752, 4749, 4484, 321, 355, 5181, 284, 2394, 3796, 9634, 3860, 5381, 1928, 9038, 7217, 8071, 8634, 4006, 9230, 4423, 3327, 3117, 7978, 2181, 4789, 5548, 3989, 5495, 7065, 8309, 556, 5696, 6631, 1429, 440, 3466, 9520, 1365, 7786, 1192, 9101, 4586, 5548, 4783, 8280, 940, 7769, 3528, 5850, 3926, 7450, 6188, 2769, 1488, 2250, 7258, 1194, 8229, 1795, 8443, 3330, 3578, 4198, 5782, 484, 9310, 9377, 3062, 9492, 8828, 2774, 269, 560, 5662, 8206, 7634, 4818, 6078, 2889, 4024, 5236, 8486, 8587, 5563, 3013, 8713, 7812, 1688, 8662, 5162, 4305, 1035, 2773, 8091, 6057, 7879, 2595, 6452, 2967, 8147, 1470, 3154, 256, 9013, 9303, 3014, 1478, 4284, 6968, 3250, 2226, 6720, 6955, 1217, 3437, 6873, 2404, 5839, 9103, 4341, 3257, 5060, 6648, 4883, 2209, 117, 9453, 7970, 839, 8399, 4084, 7156, 4404, 1615, 7446, 5756, 7058, 3277, 2046, 4720, 576, 6070, 9924, 3064, 9949, 1025, 3425, 9209, 5256, 8029, 6778, 1666, 4734, 235, 715, 5591, 7935, 2136, 5703, 1296, 5765, 6782, 7144, 1730, 3507, 2789, 217, 1533, 5388, 4555, 4988, 1329, 3011, 6210, 1528, 6774, 559, 9560, 8612, 3523, 8434, 5601, 3267, 7853, 6443, 3677, 1229, 8881, 9691, 1432, 6655, 6192, 3670, 9049, 3385, 2869, 1748, 9890, 3969, 3392, 5523, 1142, 4524, 6014, 7362, 6087, 8292, 7762, 4367, 4785, 291, 9580, 2922, 4418, 4840, 3963, 1182, 1374, 2888, 5295, 4633, 1250, 9222, 6702, 9287, 9427, 7119, 1400, 3469, 4183, 7797, 6714, 7525, 4921, 155, 6765, 6775, 8088, 6158, 6031, 5180, 5665, 876, 8273, 4742, 4617, 5762, 4614, 4925, 62, 9101, 5228, 4793, 2488, 1666, 5672, 8561, 3847, 135, 7838, 4656, 6708, 6887, 7775, 3815, 7296, 3897, 1661, 7733, 7784, 5985, 6873, 6398, 9533, 7991, 8090, 8371, 4217, 8841, 9919, 6193, 820, 7034, 2621, 8055, 5318, 6402, 2435, 1559, 7961, 3755, 7315, 4682, 8293, 4063, 5, 7478, 4047, 7149, 6242, 3653, 6754, 543, 1796, 1155, 8985, 6072, 3267, 4313, 3290, 4127, 5406, 7046, 3123, 2877, 4471, 8699, 7816, 4445, 66, 6838, 971, 456, 9681, 3528, 9938, 6490, 1219, 6754, 605, 6502, 3234, 9499, 4746, 73, 1830, 85, 6905, 8875, 1865, 6859, 3889, 1965, 9931, 7646, 6871, 5842, 3627, 3114, 4871, 2681, 3105, 9011, 7576, 8820, 7282, 2298, 9665, 3916, 8762, 2370, 7534, 1655, 8470, 9630, 9110, 1125, 4313, 1833, 8727, 4273, 2360, 100, 1248, 3256, 6260, 5856, 6463, 2777, 3294, 7515, 7092, 4271, 1663, 6368, 8470, 6857, 4559, 8913, 6692, 5632, 3535, 1781, 3320, 3843, 6788, 1662, 3558, 9880, 3863, 8896, 4180, 5441, 9368, 4387, 9263, 5445, 6453, 4739, 9362, 59, 2411, 8163, 2035, 4109, 2048, 7452, 3560, 2810, 6059, 5846, 9846, 1811, 8448, 5283, 2878, 1681, 7476, 6180, 7869, 1247, 9332, 8440, 7982, 8779, 1341, 2250, 3794, 658, 2780, 4227, 4507, 4592, 1695, 5603, 5566, 1926, 1231, 1372, 4715, 4140, 8969, 257, 1834, 666, 3073, 5854, 7856, 3326, 6039, 736, 5872, 8343, 2915, 4392, 4704, 2527, 900, 1018, 9853, 985, 7791, 1968, 9508, 5894, 8154, 2574, 2387, 7095, 6310, 2100, 5670, 1496, 8660, 2363, 1269, 6107, 1020, 7703, 3529, 7359, 6653, 3328, 7294, 8074, 2846, 3959, 2407, 8635, 8182, 4404, 8156, 3997, 8424, 8494, 3052, 9177, 4240, 8692, 1380, 8482, 2182, 9450, 5257, 1377, 2430, 4, 5626, 9972, 2140, 1643, 5721, 2975, 3065, 2514, 8718, 6970, 531, 1969, 4189, 3122, 3858, 1845, 4779, 4922, 9626, 4694, 3904, 4729, 2446, 4843, 1270, 594, 3808, 8359, 5008, 3013, 6306, 1493, 4598, 913, 2263, 4086, 2349, 9073, 2643, 7915, 4974, 4486, 7471, 6718, 7813, 3516, 2369, 849, 5200, 9383, 2037, 744, 4180, 1691, 3326, 7518, 3706, 521, 8624, 7969, 2109, 5015, 831, 5297, 9353, 2603, 1204, 7391, 1294, 4821, 2695, 4282, 345, 6157, 6182, 4588, 3250, 4844, 3772, 5886, 2228, 8679, 3238, 5969, 7762, 6781, 4212, 5407, 4061, 2333, 4396, 7424, 5917, 6593, 2245, 3181, 7804, 2363, 2456, 2499, 6689, 8306, 2188, 4194, 4943, 76, 675, 882, 7665, 3838, 9586, 2129, 4693, 2600, 1075, 4004, 9426, 1549, 8005, 1272, 9104, 4430, 424, 2957, 9135, 5091, 2449, 7967, 6277, 698, 3909, 2888, 6218, 3602, 4985, 2303, 7810, 9360, 9783, 1925, 3437, 5651, 369, 2065, 8783, 917, 9431, 8476, 7246, 6006, 1847, 9030, 5422, 4012, 2843, 6627, 6173, 560, 735, 8242, 8705, 5144, 2635, 6881, 6655, 9269, 3959, 997, 1917, 9690, 6041, 9331, 5063, 1289, 3353, 5876, 179, 8775, 8372, 305, 273, 4579, 3486, 580, 7104, 8944, 2951, 4656, 9382, 8502, 7459, 3550, 7428, 2827, 5910, 8227, 4583, 7882, 7873, 4130, 9534, 9315, 2860, 8348, 3791, 1391, 4554, 6814, 3240, 1563, 3963, 3143, 7041, 1975, 49, 2881, 9193, 6518, 6833, 8761, 37, 3558, 1276, 2023, 7398, 3433, 3125, 3498, 7693, 9554, 7111, 1131, 9914, 2753, 4344, 8209, 1854, 5275, 589, 8509, 8390, 8758, 171, 1067, 7506, 3208, 8814, 8627, 4745, 5838, 4827, 8702, 7192, 4927, 9205, 6283, 1976, 7563, 8199, 713, 9999, 2814, 2815, 6456, 9555, 2429, 6087, 8277, 6843, 817, 3775, 8594, 7248, 5342, 9247, 6966, 5752, 9871, 1730, 9590, 7089, 4654, 6373, 6154, 3942, 4354, 6614, 3041, 1234, 1846, 2306, 2215, 6551, 1402, 133, 4639, 3912, 6523, 6872, 5641, 2761, 2067, 1577, 341, 1239, 816, 6240, 8377, 6596, 618, 3194, 9363, 778, 7410, 5375, 9198, 297, 7277, 5023, 7103, 7770, 6606, 750, 6896, 7479, 95, 7233, 2387, 7203, 7631, 808, 6134, 9287, 3935, 6208, 880, 3536, 204, 2592, 5245, 6981, 5293, 9980, 6632, 3382, 1075, 5171, 3861, 1713, 2194, 8625, 7859, 1980, 651, 2351, 6753, 1969, 2469, 8717, 360, 1902, 994, 6234, 1605, 5254, 2323, 3864, 8483, 7611, 6996, 6202, 9733, 9230, 272, 4672, 9390, 3994, 1204, 9803, 9150, 1061, 9196, 8807, 9194, 8533, 4724, 7584, 7040, 3412, 7057, 9978, 3370, 1963, 9534, 8377, 8125, 9865, 2557, 7613, 4010, 148, 6086, 6179, 321, 559, 62, 1702, 2523, 9218, 8025, 3048, 6640, 2054, 5766, 5709, 5895, 6169, 4154, 431, 4842, 7902, 7395, 7384, 381, 1363, 999, 9307, 6122, 9286, 3151, 5316, 169, 9135, 382, 1723, 6604, 8687, 4263, 1349, 6849, 8765, 6727, 6255, 354, 657, 694, 8183, 9144, 2215, 2257, 5406, 2183, 883, 3982, 699, 4599, 239, 4305, 7782, 3424, 6523, 2611, 4536, 1846, 8955, 2749, 5960, 779, 2535, 4018, 4432, 1360, 3486, 2554, 9979, 4772, 8322, 527, 690, 5538, 7971, 8471, 6423, 637, 2976, 2569, 4316, 2592, 8842, 9549, 6541, 5663, 5779, 9804, 7304, 4147, 9654, 1696, 5850, 2829, 7727, 8945, 3735, 3046, 3887, 7348, 2380, 5341, 7673, 720, 1710, 3016, 9758, 2443, 2493, 8266, 1549, 2294, 748, 668, 3513, 8905, 8120, 9825, 6928, 5005, 6238, 9699, 4139, 3718, 4082, 5947, 7889, 1693, 9469, 1910, 8609, 5444, 4069, 1463, 6821, 6425, 5613, 7749, 254, 2819, 7076, 5399, 3944, 7516, 649, 2552, 9972, 8043, 2896, 3440, 3055, 9619, 3452, 9010, 176, 7029, 2271, 8428, 6051, 6320, 1918, 1008, 9619, 8468, 7754, 6971, 6244, 6050, 5478, 8717, 9444, 7692, 5506, 1325, 179, 8283, 3608, 7026, 1986, 2704, 3136, 7049, 564, 5608, 4018, 5423, 2043, 7018, 3324, 1554, 704, 6630, 4285, 1606, 7321, 1185, 2531, 7108, 2560, 2717, 2132, 9503, 4934, 8755, 6715, 2645, 7145, 5920, 9961, 5404, 7506, 650, 4921, 4638, 7886, 6909, 7304, 3398, 304, 6846, 4464, 9730, 68, 7185, 748, 5173, 2967, 4961, 921, 2451, 4522, 8533, 8232, 8506, 2964, 8569, 9182, 3745, 4589, 3554, 5488, 3434, 3877, 1671, 6189, 9944, 9665, 1774, 2288, 3783, 2206, 4702, 7917, 6003, 7110, 747, 7575, 2003, 3764, 8598, 7581, 7968, 7171, 6282, 7260, 2542, 5404, 8679, 6051, 3538, 2673, 5065, 1631, 9117, 6833, 5547, 4300, 5409, 9614, 1132, 5068, 4541, 7779, 5553, 3312, 2903, 4112, 5760, 4230, 4895, 9660, 2354, 8675, 6175, 1606, 8154, 2294, 456, 8585, 7689, 2098, 8934, 227, 6763, 5097, 9274, 5183, 4396, 2188, 8511, 1339, 7288, 9250, 1120, 5815, 3444, 758, 6648, 2915, 3351, 8898, 1401, 5449, 3238, 8663, 5155, 7876, 7354, 5624, 4121, 8187, 4808, 9912, 4944, 8703, 7237, 4032, 3448, 2380, 6677, 3545, 441, 2175, 7436, 5727, 3909, 7665, 5071, 9269, 8006, 4400, 9884, 9454, 1640, 7186, 8519, 9990, 7041, 12, 7283, 768, 8950, 9204, 2869, 86, 1807, 1320, 511, 5629, 9922, 4246, 6441, 8930, 9108, 9840, 3297, 8563, 3895, 6859, 2643, 1492, 9199, 4263, 631, 1268, 4263, 2404, 558, 373, 7745, 1561, 547, 2051, 9479, 7841, 4359, 3764, 8609, 5106, 756, 6328, 1040, 9647, 5796, 800, 2904, 2810, 9820, 423, 6762, 1263, 2183, 1890, 3237, 6408, 853, 6829, 9640, 7424, 6554, 3627, 2682, 4722, 1156, 3528, 5223, 3465, 9520, 8382, 5380, 810, 2724, 3488, 7234, 5534, 4673, 751, 2832, 5493, 7325, 7714, 9167, 638, 3175, 3798, 9554, 7160, 1845, 3642, 3789, 5905, 2756, 1958, 7918, 5893, 814, 3356, 1095, 1441, 2227, 2348, 9933, 2201, 5594, 5871, 2439, 8096, 3911, 1723, 9950, 9830, 8075, 4011, 4299, 3116, 4914, 1581, 5099, 7260, 784, 5509, 3515, 2520, 4115, 7032, 1360, 7307, 5753, 4237, 8722, 7230, 4162, 4060, 8567, 7674, 3338, 6471, 2092, 497, 5252, 8026, 3579, 7301, 9844, 3061, 9299, 7679, 2867, 259, 4698, 580, 9978, 8436, 7548, 8541, 5767, 1427, 8713, 2392, 8603, 1443, 8685, 5343, 969, 6622, 6454, 6229, 4909, 2217, 8696, 4605, 873, 955, 8110, 5496, 443, 9101, 2327, 7574, 5879, 3300, 173, 239, 2402, 7789, 4519, 2714, 5463, 5893, 8398, 891, 3074, 6612, 4908, 1970, 8333, 5401, 1415, 6383, 2117, 9641, 9549, 6633, 6866, 8820, 3037, 6650, 5279, 5896, 749, 1796, 6631, 7210, 8977, 721, 9679, 153, 5175, 5248, 3139, 5217, 3378, 85, 7545, 7936, 9658, 4998, 9115, 5043, 2603, 1126, 5905, 7572, 5654, 1331, 714, 1455, 5472, 4192, 9183, 3045, 9157, 6627, 9659, 6232, 8577, 3699, 689, 3921, 2410, 5303, 3227, 137, 6029, 6412, 224, 7405, 8346, 3071, 4401, 6892, 2557, 8173, 8913, 1614, 7000, 3964, 7567, 1581, 4636, 5207, 817, 7908, 9550, 4168, 148, 3311, 3172, 5535, 9383, 945, 6506, 9011, 383, 1032, 6560, 4970, 9331, 710, 8329, 8457, 7496, 7885, 8372, 7674, 5643, 116, 3827, 3695, 9748, 2927, 5304, 7599, 8331, 1520, 9545, 931, 9347, 274, 5807, 951, 2002, 9166, 1131, 9545, 8919, 3448, 6494, 3705, 8847, 2530, 5729, 1930, 4407, 3586, 3938, 3028, 1382, 9190, 56, 8478, 1973, 6174, 5792, 2676, 8639, 1742, 1436, 3276, 2727, 7783, 157, 9239, 2661, 758, 7468, 6123, 6661, 9143, 7251, 1514, 9867, 9177, 3154, 2754, 7310, 1854, 8604, 9363, 3921, 9483, 1786, 6851, 5320, 2891, 3656, 6349, 9835, 4918, 7153, 6992, 5761, 5972, 8910, 3969, 1541, 573, 7810, 9495, 4472, 3200, 6338, 653, 2860, 3986, 2771, 5429, 6362, 8003, 4669, 8121, 1263, 5559, 5223, 7386, 8708, 511, 7020, 197, 7917, 9846, 4240, 1184, 9474, 946, 8696, 2642, 3761, 7018, 4616, 6627, 514, 7161, 8154, 1387, 8634, 7332, 554, 9625, 9529, 9956, 4495, 9642, 5716, 5953, 4902, 1449, 1829, 4082, 3800, 1472, 8413, 7632, 2694, 8943, 6699, 3484, 9148, 9355, 1487, 1582, 7999, 1990, 6089, 831, 717, 2812, 185, 9453, 7405, 5201, 868, 7093, 190, 8758, 3747, 9966, 8190, 9315, 9955, 929, 7572, 4808, 4162, 7505, 1516, 6960, 8153, 7888, 2000, 5372, 6588, 7512, 2168, 6029, 9197, 5183, 7805, 1288, 123, 233, 3076, 1574, 4204, 3795, 4393, 8120, 5014, 7881, 4678, 1683, 1040, 3088, 6770, 4639, 2806, 6355, 1361, 1260, 5596, 2394, 253, 4037, 5655, 2920, 1381, 6164, 3608, 4610, 2645, 5230, 7016, 1359, 6268, 475, 5447, 6771, 3642, 2298, 7799, 1115, 2696, 5322, 8359, 9398, 6659, 8435, 9379, 137, 8897, 7816, 1703, 1427, 6302, 5722, 8601, 1283, 1783, 5557, 2365, 9179, 1792, 8789, 521, 6141, 5368, 3569, 3777, 3592, 6850, 9074, 4649, 5730, 5067, 3760, 230, 6534, 5048, 6283, 8081, 1050, 9665, 7782, 1148, 5494, 8631, 8682, 8569, 8099, 5604, 5165, 6905, 3811, 3777, 3916, 536, 1128, 3142, 167, 8635, 1320, 6679, 5378, 5551, 5493, 2687, 1892, 6334, 3341, 7984, 3992, 6433, 4256, 1807, 8782, 8955, 3275, 3659, 1224, 2221, 8392, 8031, 4282, 4432, 7415, 765, 8594, 1905, 4823, 9295, 3558, 1807, 4171, 5738, 4883, 3214, 4467, 4898, 9403, 8930, 1664, 5446, 527, 8685, 8992, 4557, 6685, 1608, 7591, 4725, 3438, 4724, 5254, 1699, 5654, 2669, 9717, 6288, 3919, 7842, 9048, 1366, 5582, 8887, 6882, 4024, 2177, 7301, 6190, 6014, 9457, 7521, 3119, 4491, 8869, 4389, 9826, 463, 2063, 6701, 9877, 8806, 9667, 2129, 89, 2657, 5714, 5874, 1717, 5030, 9161, 6922, 5298, 4974, 2318, 4028, 5947, 685, 8510, 9978, 1172, 6657, 1877, 6514, 4236, 3403, 1012, 3275, 5795, 7597, 746, 7908, 8376, 6961, 7698, 2536, 4525, 8886, 3232, 8270, 1981, 9027, 3520, 6504, 5768, 8709, 9948, 7644, 4067, 5731, 9103, 8486, 569, 8526, 7565, 9125, 1744, 5107, 1459, 1550, 6243, 511, 5125, 9469, 917, 3240, 766, 4526, 3289, 785, 8432, 7782, 6644, 9489, 802, 2590, 4710, 3454, 1361, 6154, 8770, 9354, 7469, 5333, 4012, 9693, 2142, 4782, 9433, 6228, 5278, 7812, 1073, 4884, 4335, 8705, 4164, 2731, 6403, 4812, 4239, 1578, 5072, 1229, 4303, 2073, 8951, 650, 2336, 4554, 6348, 1859, 1775, 9104, 2838, 170, 7374, 8261, 2771, 7541, 9842, 8829, 3492, 911, 9707, 4579, 9505, 5200, 268, 7027, 5382, 6993, 5177, 9765, 267, 4156, 5787, 7918, 7980, 6922, 6794, 6938, 8958, 5179, 48, 6757, 5154, 4674, 8168, 8647, 1724, 8585, 8944, 1613, 9875, 7286, 8201, 8970, 8742, 5881, 4765, 409, 7099, 512, 2493, 4024, 4192, 648, 8566, 7439, 3010, 3073, 8760, 3118, 6934, 4935, 8430, 9195, 7486, 8332, 4594, 9293, 2426, 1484, 8543, 6126, 9525, 7893, 7455, 7655, 3374, 3920, 1575, 8890, 5876, 8297, 4054, 8601, 6792, 6231, 3957, 9350, 1475, 2649, 5260, 6875, 4619, 8040, 5635, 101, 3414, 5258, 2692, 2249, 2944, 1535, 6658, 2731, 2879, 7314, 8653, 8425, 4562, 1392, 4033, 1555, 5422, 8576, 7818, 3145, 3496, 9193, 769, 1607, 5300, 8373, 284, 4752, 5361, 9607, 1113, 6097, 3896, 7921, 8163, 5807, 9983, 3665, 264, 981, 4605, 7901, 1731, 7659, 9152, 4433, 3434, 7880, 1278, 1970, 9708, 5457, 7393, 3126, 7470, 2100, 6284, 30, 3628, 4297, 4264, 3365, 1554, 4720, 2922, 4012, 2663, 9869, 7552, 5478, 9968, 5720, 3136, 9844, 1575, 9161, 7755, 9696, 7040, 7022, 1202, 1401, 9597, 3028, 1808, 668, 574, 8355, 813, 6837, 1836, 7498, 2968, 5595, 2733, 5321, 8578, 7003, 7850, 7904, 5998, 8117, 4389, 6675, 2960, 6054, 9644, 4915, 4667, 1164, 9233, 277, 625, 7264, 5697, 9677, 6347, 7772, 7765, 9705, 5414, 8793, 7638, 6191, 2259, 7098, 496, 8989, 145, 214, 2825, 9950, 1767, 337, 805, 8708, 3560, 7867, 4038, 6024, 4262, 3106, 1837, 9175, 255, 6217, 6225, 5409, 491, 6170, 814, 2624, 6823, 927, 5249, 1215, 533, 9187, 2449, 9743, 8241, 3622, 7933, 6092, 4837, 48, 2547, 8100, 8268, 5072, 1069, 2269, 5956, 4343, 8408, 5623, 846, 279, 9157, 2146, 6546, 4034, 8536, 9504, 1028, 9236, 3881, 8974, 4354, 263, 5972, 3093, 5774, 5065, 5563, 1595, 4211, 9132, 8111, 7441, 9106, 9412, 2570, 5519, 801, 4212, 7760, 3962, 3772, 287, 8409, 4729, 8966, 2153, 5027, 22, 8226, 8202, 9790, 3843, 3753, 2208, 730, 7306, 6346, 3783, 8126, 7364, 4767, 1550, 1335, 3137, 2244, 8931, 550, 7402, 9446, 586, 1411, 877, 9416, 2734, 2790, 8757, 5634, 9072, 4333, 9415, 9240, 3665, 8109, 7951, 7351, 9532, 7524, 6893, 475, 9083, 3757, 3570, 5994, 540, 7578, 4532, 6500, 995, 7023, 8250, 7012, 5961, 4162, 5925, 4059, 499, 747, 9294, 204, 2166, 6443, 7684, 2448, 1359, 5083, 1398, 2969, 4963, 9792, 9703, 2400, 1177, 721, 1751, 8046, 7792, 9062, 1886, 9042, 2604, 7375, 2838, 2773, 7005, 7768, 4926, 5131, 8351, 6576, 4510, 1627, 2045, 9982, 599, 2308, 4328, 4680, 5903, 5631, 3750, 6115, 9784, 4397, 2956, 5214, 5289, 9951, 914, 5396, 928, 1330, 5041, 759, 1506, 6150, 6745, 9020, 155, 2846, 2168, 9320, 4717, 6465, 8619, 8236, 4934, 9089, 4348, 1570, 5114, 4728, 9102, 4250, 5922, 3644, 4380, 8869, 6038, 1074, 3373, 1333, 1243, 9564, 6828, 9775, 6058, 7178, 2276, 6972, 561, 7083, 5118, 4637, 6871, 6154, 689, 164, 9695, 3212, 9483, 3251, 4163, 2097, 111, 6677, 951, 4669, 2816, 4152, 8582, 3415, 4426, 5769, 6582, 5830, 7473, 8923, 2378, 1396, 1835, 5562, 9290, 2169, 4690, 6109, 7989, 1085, 339, 9470, 7622, 5455, 2865, 757, 19, 3579, 2646, 1459, 7735, 4785, 7998, 5574, 6734, 4050, 1805, 8000, 2942, 91, 2746, 625, 535, 5179, 9213, 5259, 9203, 6135, 3358, 1793, 9749, 5853, 7057, 1613, 8252, 6502, 3682, 9057, 8507, 2867, 204, 9539, 2580, 9898, 3903, 864, 6434, 8451, 2509, 5360, 8682, 8622, 5886, 5143, 6740, 158, 6544, 5065, 3579, 4277, 6010, 9290, 521, 2338, 2521, 2832, 5162, 4708, 120, 7382, 5598, 826, 9700, 1302, 5917, 3233, 7830, 5499, 2036, 1833, 3621, 2662, 1774, 9014, 3305, 2622, 4264, 5669, 3731, 6819, 7773, 4986, 3709, 2615, 5231, 3328, 431, 7433, 1285, 7277, 7168, 2703, 9604, 2241, 8278, 2921, 8319, 5596, 8475, 9797, 5251, 3061, 6316, 6369, 2851, 6898, 9452, 3310, 8517, 7866, 1701, 7816, 19, 4637, 2378, 6917, 9533, 8268, 4257, 1968, 663, 3528, 4770, 9005, 1700, 6509, 5559, 2559, 1455, 1473, 5655, 2194, 8305, 9296, 2253, 5886, 1619, 2445, 9531, 6815, 7875, 7336, 3497, 4496, 328, 3204, 3474, 7419, 8989, 5263, 7124, 3914, 8530, 3303, 3594, 7952, 9868, 1162, 4167, 6891, 7740, 2600, 3767, 2019, 5566, 8788, 1868, 9540, 9657, 5188, 2142, 2570, 3481, 8057, 210, 5433, 6537, 1671, 6160, 3855, 3856, 4183, 5021, 8265, 5926, 3758, 602, 26, 2288, 7611, 9118, 6969, 3571, 3578, 3039, 7602, 7468, 4693, 4463, 7982, 5381, 4914, 6179, 852, 6993, 7606, 7935, 5229, 9195, 8912, 9630, 4853, 2345, 4059, 8323, 5383, 2837, 7713, 5586, 3366, 7071, 7385, 4511, 6699, 6176, 6068, 6376, 2994, 6483, 4566, 2788, 6874, 2275, 1928, 9368, 3885, 7875, 4338, 8543, 8017, 3057, 4637, 688, 4599, 7822, 3792, 1615, 1348, 3710, 5971, 9358, 6463, 6269, 6535, 1962, 2260, 5973, 8073, 4657, 620, 4186, 2274, 4633, 2428, 5665, 6415, 556, 410, 1, 2340, 4106, 4335, 3272, 7533, 2385, 5720, 7117, 7155, 8542, 9260, 808, 1920, 8215, 565, 4372, 7149, 229, 5745, 2029, 9146, 6351, 5124, 6206, 9515, 1354, 6444, 6425, 9630, 315, 8548, 6464, 1607, 6043, 8325, 8377, 3674, 1407, 2967, 4075, 1198, 363, 5624, 1884, 3372, 4955, 4444, 5934, 5432, 3209, 4693, 6062, 3404, 3228, 2048, 4623, 3981, 8046, 8380, 2731, 87, 3215, 2930, 7611, 8343, 6269, 5106, 7660, 109, 4292, 3098, 9543, 6055, 1075, 5013, 179, 9883, 1642, 9360, 1813, 6417, 1271, 6802, 2080, 4267, 416, 2872, 56, 7597, 8720, 3702, 7860, 8513, 3364, 4111, 5186, 249, 2184, 6810, 5801, 5668, 2511, 2893, 1661, 7026, 1672, 9364, 4814, 7729, 9221, 9305, 6623, 5217, 7781, 2552, 9290, 4230, 2997, 9273, 1033, 3836, 7073, 3793, 8635, 250, 458, 1365, 4817, 8557, 2802, 2165, 2861, 7277, 4832, 4615, 3896, 5865, 5409, 2705, 6222, 2766, 2593, 5103, 1064, 1045, 9283, 3090, 2894, 9708, 1887, 3088, 1090, 6055, 7061, 2166, 5299, 1193, 8089, 3959, 9822, 9722, 9525, 3959, 6526, 4253, 9522, 2328, 7352, 3704, 4408, 8335, 2205, 8621, 8022, 6134, 2344, 4108, 6334, 3239, 7921, 4496, 9838, 7539, 3658, 7553, 7526, 4228, 1806, 4576, 8939, 4230, 5327, 9492, 4852, 7280, 1417, 7548, 2418, 1411, 6749, 491, 6326, 2356, 5476, 7256, 1813, 6084, 2153, 9568, 7191, 6858, 8425, 5528, 7782, 1757, 9006, 7137, 620, 990, 3041, 2615, 4995, 4656, 3426, 920, 493, 7387, 8266, 2829, 2748, 4494, 1935, 1687, 721, 6781, 4998, 7592, 5026, 540, 5716, 6557, 6106, 7033, 4347, 6357, 4881, 4892, 6036, 5101, 3225, 8973, 3379, 1197, 4446, 7647, 5759, 5767, 5156, 5419, 7222, 4720, 3158, 1629, 4750, 7264, 6631, 1938, 6717, 4702, 8282, 7180, 941, 711, 5950, 9856, 7288, 1415, 3900, 3549, 1320, 4217, 2159, 2679, 1641, 7503, 5496, 4672, 7621, 5863, 3381, 8598, 9396, 6616, 6313, 8760, 9670, 1813, 841, 9339, 2065, 6082, 1851, 1665, 5402, 9276, 8902, 7609, 9440, 7053, 4357, 3514, 4159, 1664, 7207, 4954, 1519, 9142, 5170, 1688, 6216, 9058, 4684, 7035, 63, 2708, 953, 5585, 2178, 4334, 245, 9083, 5300, 8532, 3826, 8181, 3735, 426, 9084, 282, 4494, 1396, 9108, 3988, 3075, 9443, 3177, 7230, 9369, 8155, 1276, 2154, 8374, 3508, 599, 6987, 453, 1053, 2277, 7117, 8107, 5243, 5590, 9507, 9888, 7648, 3251, 5003, 7406, 3271, 3797, 5194, 3296, 6474, 3795, 7957, 6014, 8368, 7346, 4344, 6642, 9272, 1032, 9735, 1633, 715, 3464, 5518, 8984, 4378, 689, 1245, 738, 6397, 5924, 515, 7562, 5205, 7029, 9611, 488, 9308, 5649, 4641, 3699, 8835, 1012, 4719, 2146, 782, 9307, 718, 6665, 1563, 7092, 8649, 5779, 4052, 3080, 7290, 3554, 1965, 8421, 9871, 4472, 3132, 3017, 4125, 7546, 6124, 8179, 2144, 8263, 9723, 6298, 6122, 3739, 7087, 1987, 8795, 6459, 4758, 4923, 3063, 8098, 9925, 8019, 3798, 4671, 5202, 4187, 2384, 3553, 1698, 1250, 9644, 4132, 1228, 1645, 5753, 6375, 4637, 54, 3341, 5045, 5773, 305, 7078, 6582, 4036, 1846, 4034, 9912, 8416, 4431, 7726, 1617, 7763, 2386, 5510, 520, 4036, 1269, 2813, 6731, 7670, 4893, 6541, 6492, 5888, 8641, 252, 3304, 1421, 8409, 9212, 8423, 4287, 9884, 1962, 2760, 7737, 5620, 19, 5687, 3613, 6907, 4506, 5669, 8753, 6941, 8859, 357, 5258, 9160, 2627, 4016, 1385, 5359, 1478, 1652, 5354, 5733, 3133, 3879, 1498, 2803, 8079, 3245, 9581, 2529, 3912, 7230, 6757, 4282, 1010, 1774, 7059, 4995, 9298, 5229, 3074, 5593, 2293, 3634, 5731, 7435, 1602, 4163, 9181, 7493, 185, 6967, 2794, 9857, 9208, 2702, 3353, 694, 4577, 1484, 8818, 6021, 2554, 1959, 2804, 3514, 2893, 1063, 7777, 2342, 1697, 5536, 726, 9602, 8642, 297, 1689, 8340, 5153, 1380, 2587, 7442, 1709, 7188, 3332, 8719, 3208, 4582, 8575, 5027, 4103, 3221, 3852, 3573, 3529, 6691, 676, 8268, 8821, 4468, 6907, 5025, 5363, 5498, 7928, 5332, 5105, 3252, 3960, 5677, 4994, 8302, 2855, 9736, 2405, 884, 9994, 7061, 4806, 6597, 8971, 9831, 7866, 357, 4712, 2315, 7039, 9717, 9771, 8239, 2990, 5717, 3226, 7770, 6684, 1874, 5007, 4484, 540, 3938, 7783, 9139, 4017, 5344, 3875, 937, 7320, 3696, 6377, 7906, 3973, 6666, 9120, 8016, 2934, 5200, 155, 1321, 1630, 7685, 609, 5099, 3607, 315, 3231, 611, 2325, 4336, 6703, 1328, 802, 9054, 2837, 8722, 6872, 3757, 7656, 9960, 3205, 6489, 6076, 4163, 7821, 9511, 4277, 219, 6289, 4360, 4046, 5976, 7940, 1632, 1419, 61, 4370, 4288, 5570, 1443, 9098, 8311, 779, 4152, 5417, 4252, 1223, 6863, 5932, 9341, 4114, 1762, 289, 9268, 2253, 2110, 1984, 2734, 4629, 517, 9929, 7761, 3337, 6885, 1361, 7246, 2548, 1746, 9538, 8901, 1720, 8374, 5026, 6918, 3663, 8768, 8733, 434, 3251, 812, 3910, 786, 4192, 211, 1473, 5563, 5918, 7010, 738, 4913, 5877, 2189, 8223, 2992, 3890, 8069, 947, 6208, 5403, 7904, 5862, 308, 2021, 8570, 7918, 1022, 4678, 1719, 6061, 4691, 7374, 6348, 7709, 3528, 3483, 696, 1032, 1423, 2530, 7349, 2050, 6340, 9736, 4159, 2667, 9699, 1269, 925, 8051, 3417, 4215, 6817, 4372, 6698, 7983, 4126, 5133, 8728, 1269, 65, 34, 3241, 9131, 6401, 8982, 4261, 5149, 9217, 6415, 241, 1305, 4780, 5188, 2983, 6201, 1347, 8797, 4269, 1625, 9122, 667, 4731, 3634, 5730, 5189, 2686, 7781, 3241, 8388, 6775, 9671, 7134, 1754, 6289, 399, 7797, 2588, 9048, 443, 2722, 2615, 798, 9770, 3975, 3365, 779, 740, 571, 4985, 8963, 5079, 6017, 3343, 3668, 5345, 3363, 5358, 7277, 8417, 8303, 5959, 7194, 9182, 7697, 2186, 4308, 3301, 6037, 3387, 6665, 4175, 3297, 461, 5902, 4074, 5120, 5532, 6047, 6601, 6554, 853, 6898, 6997, 1269, 2896, 906, 4109, 2546, 5585, 564, 8479, 3538, 2261, 8360, 3333, 7003, 5932, 2577, 1402, 3862, 4791, 5556, 8692, 6987, 6401, 9936, 7588, 7568, 4119, 9138, 3065, 6284, 9528, 1796, 2197, 3881, 6580, 8405, 9219, 1782, 5964, 427, 6123, 1769, 3536, 6269, 6278, 1022, 2008, 9255, 9920, 2439, 3773, 7178, 9499, 6917, 7872, 691, 1306, 6446, 8980, 4299, 9662, 1225, 2129, 8801, 1003, 5360, 8364, 2798, 8951, 154, 6307, 7578, 8900, 2294, 5640, 9229, 9163, 8606, 5783, 7202, 2048, 2196, 561, 1779, 9018, 7330, 1281, 8229, 9098, 6418, 4768, 5573, 3286, 1255, 7495, 744, 7978, 4284, 1609, 4650, 27, 2379, 3870, 3949, 9085, 7208, 9107, 1079, 5940, 8067, 4122, 7983, 4473, 1912, 4681, 426, 1944, 5512, 2944, 7407, 4263, 8456, 7008, 8555, 9198, 7589, 8442, 2459, 4322, 5791, 6600, 2411, 7021, 2315, 3537, 3293, 7383, 2958, 2515, 9802, 7785, 9100, 7414, 9938, 2795, 865, 8822, 6779, 3170, 7374, 3033, 6148, 1930, 1529, 8697, 9729, 2730, 9218, 711, 502, 9145, 1679, 8686, 9145, 1358, 5498, 8788, 974, 4731, 1639, 8957, 8339, 5354, 8492, 5873, 8783, 9500, 759, 6227, 3634, 6951, 7984, 9775, 90, 718, 4626, 3882, 9117, 705, 7480, 9865, 8733, 5066, 7270, 4068, 6132, 8291, 1354, 9670, 2063, 504, 5619, 811, 8866, 4313, 8255, 935, 1345, 9350, 9178, 6613, 1069, 7369, 4224, 8112, 9823, 9491, 9976, 9448, 5372, 6377, 1457, 8482, 327, 9269, 5308, 4996, 9862, 9060, 6874, 8811, 2626, 6205, 8931, 7104, 7047, 4181, 717, 1870, 7423, 9179, 3517, 7040, 3161, 9606, 3669, 1808, 3849, 8850, 5804, 3263, 2211, 8455, 6029, 1453, 3316, 6642, 4794, 4737, 5357, 2019, 3031, 8578, 5274, 7759, 4597, 8832, 548, 9588, 6349, 7930, 2025, 2415, 3932, 783, 7603, 564, 173, 7886, 1161, 5682, 282, 7041, 3930, 9471, 950, 2699, 1043, 5289, 1537, 2325, 4168, 1655, 1229, 2589, 8488, 7971, 1323, 5692, 2504, 2324, 6948, 3347, 5268, 8268, 3022, 1332, 1419, 607, 9063, 4962, 1095, 211, 5786, 4723, 716, 510, 5302, 8151, 986, 3193, 8906, 9298, 5312, 8346, 4910, 3193, 5427, 8371, 1150, 9047, 7766, 4936, 3937, 8022, 8548, 3022, 2226, 8542, 6370, 4578, 4485, 475, 6870, 9496, 9930, 8806, 1596, 731, 3538, 5151, 4995, 8945, 2859, 6218, 2174, 8829, 4775, 4874, 8996, 4681, 5909, 9630, 1312, 9865, 7647, 3560, 2233, 2061, 2702, 5204, 7937, 1775, 7731, 4747, 9435, 8300, 4247, 7400, 9137, 2710, 4383, 273, 8306, 7065, 8599, 4944, 2984, 1274, 2795, 5992, 4014, 6375, 3105, 7821, 4709, 7171, 153, 7548, 2267, 7089, 9785, 6527, 8219, 9086, 33, 5453, 2737, 9049, 5034, 5145, 3584, 7147, 7361, 8642, 4626, 7809, 9023, 8846, 6433, 8633, 6728, 1003, 6272, 4165, 7118, 9270, 10, 5890, 472, 8041, 2751, 8334, 886, 9826, 990, 5371, 5897, 9786, 9158, 4822, 959, 4007, 7818, 9637, 3238, 3657, 7986, 8152, 7493, 3995, 9742, 2868, 4963, 8503, 5441, 2153, 6512, 7358, 6899, 564, 9659, 1259, 4692, 4059, 5328, 8681, 5241, 1304, 3168, 5276, 29, 4269, 6895, 1093, 5498, 8093, 8070, 2721, 3182, 5586, 4946, 5194, 9115, 8498, 8678, 7107, 5722, 3679, 6484, 6404, 6831, 5325, 7914, 7312, 2532, 5179, 9020, 4819, 7293, 8239, 3622, 3311, 3641, 8774, 6016, 5584, 9433, 1111, 3998, 9696, 1973, 9695, 3730, 2055, 8113, 9614, 8229, 2776, 3140, 9582, 7934, 4047, 1784, 5711, 5755, 1420, 5105, 4956, 484, 7946, 6463, 5043, 3585, 3174, 5115, 3519, 5597, 3450, 9231, 5772, 1701, 8108, 8142, 9365, 337, 9584, 2742, 5931, 8864, 5375, 6576, 3719, 5366, 3877, 3208, 9076, 4922, 3798, 5482, 307, 5058, 732, 9680, 3010, 1831, 9309, 8684, 9052, 8857, 1775, 5, 4398, 5749, 2310, 8836, 7172, 2741, 8124, 2320, 302, 2464, 5793, 9807, 6456, 6387, 5332, 4800, 3849, 6817, 9354, 6668, 4977, 744, 6607, 3294, 6815, 3603, 2340, 885, 5990, 7882, 7992, 5327, 1749, 8214, 9045, 1986, 3903, 312, 6754, 3121, 2659, 9489, 7887, 8440, 6656, 2651, 6237, 272, 5258, 3437, 6579, 1721, 7383, 31, 1856, 4118, 1700, 2034, 3543, 912, 2043, 2287, 9310, 4892, 7746, 1419, 3479, 1920, 2913, 4478, 1818
            };
            Console.WriteLine(s.ConnectSticks(arr));
        }
    }

    class Solution
    {
        public int ConnectSticks(int[] sticks)
        {
            if (sticks.length == 0 || sticks == null || sticks.length == 1) return 0;
            int TotalCost = 0;
            PriorityQueue<Integer> minHeap = new PriorityQueue<>();
            for (int i = 0; i < sticks.length; i++)
                minHeap.add(sticks[i]);
            while (minHeap.size() > 1)
            {
                int localCost = minHeap.remove() + minHeap.remove();
                TotalCost += localCost;
                minHeap.add(localCost);
            }
            return TotalCost;
        }
    }
}
}