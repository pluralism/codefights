def DivisibleSubstrings(s)
  dp = Hash.new
  dp[0] = 0
  dp[1] = 0
  dp[2] = 0
  dp[3] = 0
  dp[4] = 0
  dp[5] = 0
  dp[6] = 0
  dp[7] = 0
  dp[8] = 0
  dp[9] = 0

  found = Array.new(3, 0)
  last_found = Array.new(3, 0)

  found9 = Array.new(9, 0)
  last_found9 = Array.new(9, 0)

  found7 = Array.new(7, 0)
  last_found7 = Array.new(7, 0)
  digits7 = [0,3,6,2,5,1,4]


  for i in 0...s.length
    # For 1
    dp[1] += i + 1

    # For 3
    tmp = s[i].to_i % 3
    found[(tmp + 0) % 3] = last_found[0] + 1
    found[(tmp + 1) % 3] = last_found[1]
    found[(tmp + 2) % 3] = last_found[2]

    dp[3] += found[0]

    # For 2
    if s[i].to_i % 2 == 0
      # Might need to revise later
      dp[6] += found[0]
      dp[2] += i + 1
    end
    found, last_found = last_found, found

    # For 4
    dp[4] += 1 if s[i].to_i % 4 == 0
    if i > 0
      dp[4] += i if s[i - 1..i].to_i % 4 == 0
    end

    # For 5
    dp[5] += i + 1 if s[i].to_i % 5 == 0


    # For 7
    tmp = s[i].to_i % 7
    found7[0] = last_found7[-tmp % 7]
    found7[1] = last_found7[(5 - tmp) % 7]
    found7[2] = last_found7[(3 - tmp) % 7]
    found7[3] = last_found7[(1 - tmp) % 7]
    found7[4] = last_found7[(6 - tmp) % 7]
    found7[5] = last_found7[(4 - tmp) % 7]
    found7[6] = last_found7[(2 - tmp) % 7]
    found7[digits7[tmp]] += 1

    dp[7] += found7[0]
    found7, last_found7 = last_found7, found7


    # For 8
    dp[8] += 1 if s[i].to_i % 8 == 0
    if i > 0
      dp[8] += 1 if s[i - 1..i].to_i % 8 == 0
      dp[8] += i - 1 if i > 1 and s[i - 2..i].to_i % 8 == 0
    end


    # For 9
    tmp = s[i].to_i % 9
    found9[(tmp + 0) % 9] = last_found9[0] + 1
    found9[(tmp + 1) % 9] = last_found9[1]
    found9[(tmp + 2) % 9] = last_found9[2]
    found9[(tmp + 3) % 9] = last_found9[3]
    found9[(tmp + 4) % 9] = last_found9[4]
    found9[(tmp + 5) % 9] = last_found9[5]
    found9[(tmp + 6) % 9] = last_found9[6]
    found9[(tmp + 7) % 9] = last_found9[7]
    found9[(tmp + 8) % 9] = last_found9[8]

    dp[9] += found9[0]
    found9, last_found9 = last_found9, found9
  end
  dp.values
end
