def DivisibleSubstrings(s)
  dp = Hash.new
  for i in 0..9
    dp[i] = 0
  end

  f1, f2 = [0, 0, 0], [0, 0, 0]

  f3, f4 = [0, 0, 0, 0, 0, 0, 0, 0, 0], [0, 0, 0, 0, 0, 0, 0, 0, 0]

  f5, f6 = [0, 0, 0, 0, 0, 0, 0], [0, 0, 0, 0, 0, 0, 0]
  f7 = [0,3,6,2,5,1,4]


  for i in 0...s.length
    dp[1] += i + 1

    tmp = s[i].to_i % 3
    f1[(tmp + 0) % 3] = f2[0] + 1
    f1[(tmp + 1) % 3] = f2[1]
    f1[(tmp + 2) % 3] = f2[2]
    dp[3] += f1[0]

    if s[i].to_i % 2 == 0
      dp[6] += f1[0]
      dp[2] += i + 1
    end
    f1, f2 = f2, f1

    dp[4] += 1 if s[i].to_i % 4 == 0
    dp[4] += i if i > 0 and s[i - 1..i].to_i % 4 == 0

    dp[5] += i + 1 if s[i].to_i % 5 == 0

    tmp = s[i].to_i % 7
    f5[0] = f6[-tmp % 7]
    f5[1] = f6[(5 - tmp) % 7]
    f5[2] = f6[(3 - tmp) % 7]
    f5[3] = f6[(1 - tmp) % 7]
    f5[4] = f6[(6 - tmp) % 7]
    f5[5] = f6[(4 - tmp) % 7]
    f5[6] = f6[(2 - tmp) % 7]
    f5[f7[tmp]] += 1

    dp[7] += f5[0]
    f5, f6 = f6, f5

    dp[8] += 1 if s[i].to_i % 8 == 0
    if i > 0
      dp[8] += 1 if s[i - 1..i].to_i % 8 == 0
      dp[8] += i - 1 if i > 1 and s[i - 2..i].to_i % 8 == 0
    end


    tmp = s[i].to_i % 9
    f3[(tmp + 0) % 9] = f4[0] + 1
    for k in 1..8
      f3[(tmp + k) % 9] = f4[k]
    end

    dp[9] += f3[0]
    f3, f4 = f4, f3
  end
  dp.values
end
