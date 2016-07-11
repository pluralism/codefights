def MultipleNumber(n)
  n = n.split("").map(&:to_i).reduce(:*).to_s while n.to_i >= 10
  n
end

puts MultipleNumber("1234")
