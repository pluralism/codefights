#You're given an array of unsorted integers arr. Find the maximum length of a contiguous subarray that contains at most 2 different integers (possibly several times).
#
#Example
#
#For arr = [7, 4, 5, 4, 4, 6], the output should be
#findBiSlice(arr) = 4.
#
#The longest contiguous subarray that consists of only 2 integers is [4, 5, 4, 4], and it contains 4 elements.
#
#Input/Output
#
#[time limit] 4000ms (rb)
#[input] array.integer arr
#
#Array of integers.
#
#Constraints:
#2 ≤ arr.length ≤ 8000,
#1 ≤ arr[i] ≤ 104.
#
#[output] integer
#
#The length of the maximal contiguous subarray containing no more than 2 integers.
def findBiSlice(arr)
  a = b = c = 0
  d = Hash.new(0)

  for i in 0...arr.length
    for j in i...arr.length
      if d[arr[j]] == 0
        break if c >= 2
        c += 1
        d[arr[j]] = 1
      end
      b += 1
    end
    a = b if b > a
    b = c = 0
    d = d.clear
  end
  a
end
