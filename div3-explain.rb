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

DivisibleSubstrings "350"
