#include "pch.h"
#include "../Odometer/odometer.h"
#include<vector>

using namespace std;

Odometer odometer3(3);
Odometer odometer4(4);
Odometer odometer5(5);
Odometer odometer6(6);
Odometer odometer7(7);
Odometer odometer8(8);

TEST(TestisAscending, IsAscendingWorking) {
  
	bool isAscending1 = odometer3.isAscending(123);
	bool isAscending2 = odometer4.isAscending(5678);
	bool isAscending3 = odometer5.isAscending(123467);
	bool isAscending4 = odometer6.isAscending(178934);
	bool isAscending5 = odometer7.isAscending(98765);
	bool isAscending6 = odometer8.isAscending(7777);

	EXPECT_TRUE(isAscending1);
	EXPECT_TRUE(isAscending2);
	EXPECT_TRUE(isAscending3);
	EXPECT_FALSE(isAscending4);
	EXPECT_FALSE(isAscending5);
	EXPECT_FALSE(isAscending6);
}

TEST(TestgetValidSize, IsgetValidSizeWorking) {

	int validSize1 = odometer3.getValidSize(6);
	int validSize2 = odometer4.getValidSize(2);
	int validSize3 = odometer5.getValidSize(9);
	int validSize4 = odometer5.getValidSize(10);
	int validSize5 = odometer5.getValidSize(7);
	int validSize6 = odometer5.getValidSize(1);

	EXPECT_EQ(validSize1, 6);
	EXPECT_EQ(validSize2, 3);
	EXPECT_EQ(validSize3, 3);
	EXPECT_EQ(validSize4, 3);
	EXPECT_EQ(validSize5, 7);
	EXPECT_EQ(validSize6, 3);
}

TEST(TestgetStart, IsgetStartWorking) {

	int start3 = odometer3.getStart();
	int start4 = odometer4.getStart();
	int start5 = odometer5.getStart();
	int start6 = odometer6.getStart();
	int start7 = odometer7.getStart();
	int start8 = odometer8.getStart();

	EXPECT_EQ(start3, 123);
	EXPECT_EQ(start4, 1234);
	EXPECT_EQ(start5, 12345);
	EXPECT_EQ(start6, 123456);
	EXPECT_EQ(start7, 1234567);
	EXPECT_EQ(start8, 12345678);

}

TEST(TestgetEnd, IsgetEndWorking) {

	int end3 = odometer3.getEnd();
	int end4 = odometer4.getEnd();
	int end5 = odometer5.getEnd();
	int end6 = odometer6.getEnd();
	int end7 = odometer7.getEnd();
	int end8 = odometer8.getEnd();

	EXPECT_EQ(end3, 789);
	EXPECT_EQ(end4, 6789);
	EXPECT_EQ(end5, 56789);
	EXPECT_EQ(end6, 456789);
	EXPECT_EQ(end7, 3456789);
	EXPECT_EQ(end8, 23456789);

}

TEST(TestgetReadings, IsgetReadingsWorking) {

	vector<int> readings3{ 123, 124, 125, 126, 127, 128, 129, 134, 135, 136,
						  137, 138, 139, 145, 146, 147, 148, 149, 156, 157,
						  158, 159, 167, 168, 169, 178, 179, 189, 234, 235,
						  236, 237, 238, 239, 245, 246, 247, 248, 249, 256,
						  257, 258, 259, 267, 268, 269, 278, 279, 289, 345,
						  346, 347, 348, 349, 356, 357, 358, 359, 367, 368,
						  369, 378, 379, 389, 456, 457, 458, 459, 467, 468,
						  469, 478, 479, 489, 567, 568, 569, 578, 579, 589,
						  678, 679, 689, 789 };
	vector<int> readings4{ 1234, 1235, 1236, 1237, 1238, 1239, 1245, 1246, 1247, 1248,
						  1249, 1256, 1257, 1258, 1259, 1267, 1268, 1269, 1278, 1279,
						  1289, 1345, 1346, 1347, 1348, 1349, 1356, 1357, 1358, 1359,
						  1367, 1368, 1369, 1378, 1379, 1389, 1456, 1457, 1458, 1459,
						  1467, 1468, 1469, 1478, 1479, 1489, 1567, 1568, 1569, 1578,
						  1579, 1589, 1678, 1679, 1689, 1789, 2345, 2346, 2347, 2348,
						  2349, 2356, 2357, 2358, 2359, 2367, 2368, 2369, 2378, 2379,
						  2389, 2456, 2457, 2458, 2459, 2467, 2468, 2469, 2478, 2479,
						  2489, 2567, 2568, 2569, 2578, 2579, 2589, 2678, 2679, 2689,
						  2789, 3456, 3457, 3458, 3459, 3467, 3468, 3469, 3478, 3479,
						  3489, 3567, 3568, 3569, 3578, 3579, 3589, 3678, 3679, 3689,
						  3789, 4567, 4568, 4569, 4578, 4579, 4589, 4678, 4679, 4689,
						  4789, 5678, 5679, 5689, 5789, 6789 };
	vector<int> readings5{ 12345, 12346, 12347, 12348, 12349, 12356, 12357, 12358, 12359, 12367,
						  12368, 12369, 12378, 12379, 12389, 12456, 12457, 12458, 12459, 12467,
						  12468, 12469, 12478, 12479, 12489, 12567, 12568, 12569, 12578, 12579,
						  12589, 12678, 12679, 12689, 12789, 13456, 13457, 13458, 13459, 13467,
						  13468, 13469, 13478, 13479, 13489, 13567, 13568, 13569, 13578, 13579,
						  13589, 13678, 13679, 13689, 13789, 14567, 14568, 14569, 14578, 14579,
						  14589, 14678, 14679, 14689, 14789, 15678, 15679, 15689, 15789, 16789,
						  23456, 23457, 23458, 23459, 23467, 23468, 23469, 23478, 23479, 23489,
						  23567, 23568, 23569, 23578, 23579, 23589, 23678, 23679, 23689, 23789,
						  24567, 24568, 24569, 24578, 24579, 24589, 24678, 24679, 24689, 24789,
						  25678, 25679, 25689, 25789, 26789, 34567, 34568, 34569, 34578, 34579,
						  34589, 34678, 34679, 34689, 34789, 35678, 35679, 35689, 35789, 36789,
						  45678, 45679, 45689, 45789, 46789, 56789 };
	vector<int> readings6{ 123456, 123457, 123458, 123459, 123467, 123468, 123469, 123478, 123479, 123489,
						  123567, 123568, 123569, 123578, 123579, 123589, 123678, 123679, 123689, 123789,
						  124567, 124568, 124569, 124578, 124579, 124589, 124678, 124679, 124689, 124789,
						  125678, 125679, 125689, 125789, 126789, 134567, 134568, 134569, 134578, 134579,
						  134589, 134678, 134679, 134689, 134789, 135678, 135679, 135689, 135789, 136789,
						  145678, 145679, 145689, 145789, 146789, 156789, 234567, 234568, 234569, 234578,
						  234579, 234589, 234678, 234679, 234689, 234789, 235678, 235679, 235689, 235789,
						  236789, 245678, 245679, 245689, 245789, 246789, 256789, 345678, 345679, 345689,
						  345789, 346789, 356789, 456789 };
	vector<int> readings7{ 1234567, 1234568, 1234569, 1234578, 1234579, 1234589, 1234678, 1234679, 1234689, 1234789,
						  1235678, 1235679, 1235689, 1235789, 1236789, 1245678, 1245679, 1245689, 1245789, 1246789,
						  1256789, 1345678, 1345679, 1345689, 1345789, 1346789, 1356789, 1456789, 2345678, 2345679,
						  2345689, 2345789, 2346789, 2356789, 2456789, 3456789 };
	vector<int> readings8{ 12345678, 12345679, 12345689, 12345789, 12346789, 12356789, 12456789, 13456789, 23456789};

	EXPECT_EQ(readings3, odometer3.getReadings(123, 789));
	EXPECT_EQ(readings4, odometer4.getReadings(1234, 6789));
	EXPECT_EQ(readings5, odometer5.getReadings(12345, 56789));
	EXPECT_EQ(readings6, odometer6.getReadings(123456, 456789));
	EXPECT_EQ(readings7, odometer7.getReadings(1234567, 3456789));
	EXPECT_EQ(readings8, odometer8.getReadings(12345678, 23456789));

}