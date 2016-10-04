# This was actually quite a challenging problem to solve
# Let's imagine a simple string A C T G A. The result for this sequence
# should be *2* because the substring ACTG appears twice in the string,
# in the form A C T G and C T G A.
#
# Let's break the problem down and count each of the occurrences.
# A C T G
# 0 0 0 0 -> empty string
# 1 0 0 0 -> A
# 1 1 0 0 -> AC
# 1 1 1 0 -> ACT
# 1 1 1 1 -> ACTG
# 2 1 1 1 -> ACTGA
#
# A sequence is ONLY valid when you have the SAME number of A's, C's, T's and G's.
# The first valid sequence is ACTG because each of the symbols appear once.
# The second valid sequence is CTGA because you appended CTGA to A.
# If you subtract 2 1 1 1 and 1 0 0 0 you will get 1 1 1 1, that tells you that once
# again each symbol appears exactly once.
#
# Another way to think about this is to subtract the number of A to C, C to G and G to T and store it in
# an array with 3 elements [A - C, C - G, G - T]
#
# For example, for A you have [1, 0, 0] and for ACTGA you also have [1, 0, 0], which means this must
# be a valid sequence and you found your first valid sequence. The other valid sequence is [0, 0, 0]
# in the empty string and [0, 0, 0] in ACTG, hence the result is *2*.
#
# So, what's happening here?
#
# Let's take ACTGACTG as an example:
# Let's just work in the [0, 0, 0] example, which means ACTG substrings in this order.
#
# Initially the empty string is [0, 0, 0], so [0, 0, 0] appeared once and sum is 0.
# When you find ACTG you found another [0, 0, 0] substring, so now you have to update
# the sum variable. Sum is now the value you had for sum(0) plus the number of times
# [0, 0, 0] appeared(1). Sum is now 0 + 1 = 1 and [0, 0, 0] appeared 2 times.
# When you find another ACTG in ACTGACTG you found another [0, 0, 0] substring,
# so you have to update the sum variable. You had that sum = 1 and [0, 0, 0] appeared twice,
# which means now sum = 1 + 2 = 3. This is basically the sum of the first N - 1 numbers,
# which you could also write as N * (N - 1) / 2. You have to repeat the same proccess for
# every [A - C, C - G, G - T] you find.
def dnaSequence s
  hash, diff = Hash.new(0), Hash.new(0)
  diff[[0, 0, 0]] = 1

  sum = 0
  s.chars.each { |c|
    hash[c] += 1
    res = [hash['A'] - hash['C'], hash['C'] - hash['G'], hash['G'] - hash['T']]
    sum += diff[res]
    diff[res] += 1
  }
  sum
end
