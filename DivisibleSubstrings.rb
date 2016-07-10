require 'benchmark'


puts Benchmark.measure {
  s = "00"
  #for i in 0...21000
    #s << "2"
  #end

  dp = Hash.new
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

    # For 8
    dp[8] += 1 if s[i].to_i % 8 == 0
    if i > 0
      dp[8] += 1 if s[i - 1..i].to_i % 8 == 0
      dp[8] += i if i > 1 and s[i - 2..i].to_i % 8 == 0
    end

    # For 5
    dp[5] += i + 1 if s[i].to_i % 5 == 0


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


  puts "0: 0"
  puts "1: #{dp[1]}"
  puts "2: #{dp[2]}"
  puts "3: #{dp[3]}"
  puts "4: #{dp[4]}"
  puts "5: #{dp[5]}"
  puts "6: #{dp[6]}"
  puts "7: #{dp[7]}"
  puts "8: #{dp[8]}"
  puts "9: #{dp[9]}"
}
