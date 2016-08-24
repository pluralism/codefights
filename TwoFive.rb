def TwoFive(a)
  d, s = "23456789ABCDEFGHJKLMNPQRSTUVWXYZ", ""
  a.map { |x| s = "#{"%08b" % x}#{s}" }
  puts s
  s.reverse.scan(/.{1,5}/).map { |x| x = d[x.reverse.to_i(2)] }.join
end
