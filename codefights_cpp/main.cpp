#define CATCH_CONFIG_MAIN
#include <iostream>
#include "catch.hpp"
using namespace std;

/**
 * Given the day, the month and the number n, your task is to calculate the number
 * of wagons Tom will miss.
 * Assume that this and the following years are both non-leap.
*/
int toms_wagons(int e, int q, int n) {
  int d[] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
  int s = 0, a = q, b = e - 1, c = n;

  while(c)
  {
    s += 1 + (2 * (a - 1));
    a += 1;
    if(a > d[b]) {
      b = (b + 1) % 12;
      a = 1;
    }
    c--;
  }
  return s;
}

TEST_CASE("Results are computed correctly", "[toms_wagons]") {
  REQUIRE(toms_wagons(1, 1, 1) == 1);
  REQUIRE(toms_wagons(3, 2, 4) == 24);
  REQUIRE(toms_wagons(2, 1, 30) == 788);
  REQUIRE(toms_wagons(5, 10, 11) == 319);
  REQUIRE(toms_wagons(12, 29, 10) == 226);
  REQUIRE(toms_wagons(5, 30, 0) == 0);
  REQUIRE(toms_wagons(12, 31, 2) == 62);
  REQUIRE(toms_wagons(7, 20, 57) == 1757);
  REQUIRE(toms_wagons(1, 17, 222) == 6848);
  REQUIRE(toms_wagons(10, 27, 205) == 6113);
}
