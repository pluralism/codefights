def DivisibleSubstrings s
  dp = Hash.new
  dp[3] = 0

  found, last_found = Array.new(3, 0), Array.new(3, 0)

  for i in 0...3
    tmp = s[i].to_i % 3

    found[(tmp + 0) % 3] = last_found[0] + 1
    found[(tmp + 1) % 3] = last_found[1]
    found[(tmp + 2) % 3] = last_found[2]

    puts "#{found[(tmp + 0) % 3]} #{found[(tmp + 1) % 3]} #{found[(tmp + 2) % 3]}"
    dp[3] += found[0]

    p "[BEFORE] Found: #{found}, last_found: #{last_found}"
    found, last_found = last_found, found
    p "[AFTER] Found: #{found}, last_found: #{last_found}"
  end
  puts dp[3]
end

# Iteration by iteration:
# dp[3] = 0
# found = [0, 0, 0]
# last_found = [0, 0, 0]
#
# i = 0
# tmp = 3 % 3 = 0 . The number is a multiple of 3, then we have found a solution
# We will always update the residue of 0 because that contains the numbers multiple of 3
# found[(tmp + 0) % 3] = last_found[0] + 1 -> found[0] = 0 + 1 -> found[0] = 1
# found[(tmp + 1) % 3] = last_found[1] -> found[1] = 0
# found[(tmp + 2) % 3] = last_found[2] -> found[2] = 0
#
# dp[3] += found[0] -> dp[3] += 1 -> dp[3] = 1
# found, last_found = last_found, found -> found = [0, 0, 0], last_found = [1, 0, 0]
# At this point we finished the first iteration and we know that we found 1 number multiple of 3
DivisibleSubstrings "350"
