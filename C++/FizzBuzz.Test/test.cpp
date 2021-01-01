#include "pch.h"
#include "../FizzBuzz/fizzbuzz.h"

TEST(FizzBuzzTest, doesReturnNumberWhenNotaMultiple) {
	ASSERT_STREQ("1", fizzbuzz(1).c_str());
	ASSERT_STREQ("2", fizzbuzz(2).c_str());
	ASSERT_STREQ("4", fizzbuzz(4).c_str());
	ASSERT_STREQ("7", fizzbuzz(7).c_str());
	ASSERT_STREQ("8", fizzbuzz(8).c_str());
	ASSERT_STREQ("11", fizzbuzz(11).c_str());
	ASSERT_STREQ("13", fizzbuzz(13).c_str());
	ASSERT_STREQ("14", fizzbuzz(14).c_str());
	ASSERT_STREQ("16", fizzbuzz(16).c_str());
	ASSERT_STREQ("17", fizzbuzz(17).c_str());
}

TEST(FizzBuzzTest, doesReturnFizzWhenMultipleofThree) {

	ASSERT_STREQ("Fizz", fizzbuzz(3).c_str());
	ASSERT_STREQ("Fizz", fizzbuzz(6).c_str());
	ASSERT_STREQ("Fizz", fizzbuzz(9).c_str());
	ASSERT_STREQ("Fizz", fizzbuzz(12).c_str());
	ASSERT_STREQ("Fizz", fizzbuzz(18).c_str());
	ASSERT_STREQ("Fizz", fizzbuzz(21).c_str());
	ASSERT_STREQ("Fizz", fizzbuzz(24).c_str());
	ASSERT_STREQ("Fizz", fizzbuzz(27).c_str());
	ASSERT_STREQ("Fizz", fizzbuzz(33).c_str());
	ASSERT_STREQ("Fizz", fizzbuzz(36).c_str());
}

TEST(FizzBuzzTest, doesReturnBuzzWhenMultipleofFive) {

	ASSERT_STREQ("Buzz", fizzbuzz(5).c_str());
	ASSERT_STREQ("Buzz", fizzbuzz(10).c_str());
	ASSERT_STREQ("Buzz", fizzbuzz(20).c_str());
	ASSERT_STREQ("Buzz", fizzbuzz(25).c_str());
	ASSERT_STREQ("Buzz", fizzbuzz(35).c_str());
	ASSERT_STREQ("Buzz", fizzbuzz(40).c_str());
	ASSERT_STREQ("Buzz", fizzbuzz(50).c_str());
	ASSERT_STREQ("Buzz", fizzbuzz(55).c_str());
	ASSERT_STREQ("Buzz", fizzbuzz(65).c_str());
	ASSERT_STREQ("Buzz", fizzbuzz(70).c_str());
}

TEST(FizzBuzzTest, doesReturnFizzBuzzWhenMultipleofFifteen) {

	ASSERT_STREQ("FizzBuzz", fizzbuzz(15).c_str());
	ASSERT_STREQ("FizzBuzz", fizzbuzz(30).c_str());
	ASSERT_STREQ("FizzBuzz", fizzbuzz(45).c_str());
	ASSERT_STREQ("FizzBuzz", fizzbuzz(60).c_str());
	ASSERT_STREQ("FizzBuzz", fizzbuzz(75).c_str());
	ASSERT_STREQ("FizzBuzz", fizzbuzz(90).c_str());
	ASSERT_STREQ("FizzBuzz", fizzbuzz(105).c_str());
	ASSERT_STREQ("FizzBuzz", fizzbuzz(120).c_str());
	ASSERT_STREQ("FizzBuzz", fizzbuzz(135).c_str());
	ASSERT_STREQ("FizzBuzz", fizzbuzz(150).c_str());
}
